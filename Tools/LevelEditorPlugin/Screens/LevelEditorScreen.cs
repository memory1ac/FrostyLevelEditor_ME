using Frosty.Core.Screens;
using Frosty.Core.Viewport;
using Frosty.Core.Viewport.DXUT;
using Frosty.Core.Windows;
using FrostySdk;
using LevelEditorPlugin.BF1Core.Utils;
using LevelEditorPlugin.BF1Core;
using LevelEditorPlugin.Editors;
using LevelEditorPlugin.Entities;
using LevelEditorPlugin.Options;
using LevelEditorPlugin.Library.Image;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Render;
using LevelEditorPlugin.Render.Proxies;
using SharpDX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using D3D11 = SharpDX.Direct3D11;

namespace LevelEditorPlugin.Screens;

public delegate void RenderAction(RenderCreateState state);

public class LevelEditorCamera : FirstPersonCamera
{
    public float FOV => fov;
    public float AspectRatio => aspectRatio;

    public Matrix WorldMatrix
    {
        get
        {
            return Matrix.RotationYawPitchRoll(-cameraYawAngle, cameraPitchAngle, 0) * Matrix.Translation(cameraWorldMatrix.TranslationVector * new Vector3(-1, 1, 1));
        }
    }

    public LevelEditorCamera()
    {
        rotationScaler = 0.015f;
        moveScaler = 10.0f;
    }
}

public class GizmoRenderProxy : MeshRenderBase
{
    public Matrix Transform { get; set; }
    public float Scale { get; protected set; }

    private ObjRenderable renderData;

    private ShaderPermutation permutation;
    private D3D11.Buffer pixelParameters;
    private List<D3D11.ShaderResourceView> pixelTextures = [];
    private Matrix originalTransform;

    private List<ShaderParameter> materialParameters = [];
    private List<ShaderParameter> materialTextures = [];

    private static GeometryDeclarationDesc GeometryDecl = GeometryDeclarationDesc.Create(new GeometryDeclarationDesc.Element[]
    {
        new GeometryDeclarationDesc.Element
        {
            Usage = VertexElementUsage.Pos,
            Format = VertexElementFormat.Float3
        },
        new GeometryDeclarationDesc.Element
        {
            Usage = VertexElementUsage.Normal,
            Format = VertexElementFormat.Float3
        },
        new GeometryDeclarationDesc.Element
        {
            Usage = VertexElementUsage.TexCoord0,
            Format = VertexElementFormat.Float2
        }
    });

    public GizmoRenderProxy(RenderCreateState state, ObjRenderable meshData)
    {
        renderData = meshData;
        Transform = Matrix.Identity;
        originalTransform = Transform;

        CreateMaterial(state);
    }

    public override void Render(D3D11.DeviceContext context, MeshRenderPath renderPath)
    {
        Matrix cameraTransform = Screens.LevelEditorScreen.EditorCamera.WorldMatrix;

        float distToCamera = (Transform.TranslationVector - cameraTransform.TranslationVector).Length();
        Scale = Math.Max(distToCamera / 5.0f, 0.125f);

        Transform = Matrix.Scaling(Scale) * Matrix.Translation(Transform.TranslationVector);

        if (renderPath == MeshRenderPath.Forward)
        {
            permutation.SetState(context, renderPath);
            context.PixelShader.SetShaderResources(1, pixelTextures.ToArray());
            context.PixelShader.SetConstantBuffer(2, pixelParameters);

            renderData.Render(context, renderPath);
        }
    }

    public virtual MeshRenderInstance GetInstance(float distToCamera)
    {
        return new MeshRenderInstance() { RenderMesh = this, Transform = Transform };
    }

    public void UpdateSelectIndex(RenderCreateState state, int newSelectIndex)
    {
        materialParameters.Clear();
        materialParameters.Add(new ShaderParameter("SelectIndex", ShaderParameterType.Float4, new[] { (float)newSelectIndex, 0, 0, 0 }));
        permutation.AssignParameters(state, materialParameters, materialTextures, ref pixelParameters, ref pixelTextures);
    }

    private void CreateMaterial(RenderCreateState state)
    {
        materialTextures.Add(new ShaderParameter("Texture", ShaderParameterType.Tex2d, $"Resources/Textures/TranslateGizmo.dds"));
        materialTextures.Add(new ShaderParameter("SelectMask", ShaderParameterType.Tex2d, $"Resources/Textures/TranslateGizmoSelected.dds"));

        permutation = state.ShaderLibrary.GetUserShader("GizmoShader", GeometryDecl);
        permutation.IsTwoSided = true;
        permutation.LoadShaders(state.Device);
        permutation.AssignParameters(state, materialParameters, materialTextures, ref pixelParameters, ref pixelTextures);
    }

    public void Dispose()
    {
        renderData.Dispose();
        permutation.Dispose();
        pixelParameters?.Dispose();
        pixelTextures.Clear();
    }
}

public class Gizmo
{
    public bool IsVisible { get; set; }
    public Matrix Transform
    {
        get => renderProxy.Transform;
        set
        {
            if (renderProxy.Transform != value)
            {
                renderProxy.Transform = value;
            }
        }
    }
    public BoundingBox BoundingBox { get; protected set; }

    protected ObjRenderable meshData;
    protected string meshFilename;

    protected GizmoRenderProxy renderProxy;

    public Gizmo()
    {
        IsVisible = false;
    }

    public void CreateRenderProxy(RenderCreateState state)
    {
        meshData = LoadedMeshManager.Instance.LoadMesh(state, "TranslateGizmo");
        renderProxy = new GizmoRenderProxy(state, meshData);
    }

    public MeshRenderInstance GetInstance()
    {
        return renderProxy.GetInstance(0.0f);
    }

    public virtual bool HitTest(Ray hitTestRay)
    {
        return IsVisible && hitTestRay.Intersects(BoundingBox);
    }

    public virtual void Update(RenderCreateState state)
    {
    }

    public virtual bool MouseDown(int x, int y, Ray rayCast, MouseButton button)
    {
        return false;
    }

    public virtual bool MouseMove(int x, int y, Ray rayCast)
    {
        return true;
    }

    public virtual bool MouseUp(int x, int y, Ray rayCast, MouseButton button)
    {
        return false;
    }

    public void Dispose()
    {
        renderProxy.Dispose();
        LoadedMeshManager.Instance.UnloadMesh(meshData);
    }
}

public class TranslateGizmo : Gizmo
{
    public bool IsMoving => moved;

    private BoundingBox[] axisBoundingBoxes = new BoundingBox[3]
    {
        new BoundingBox(Vector3.Zero, new Vector3(0.25f, 0.25f, 1.0f)),
        new BoundingBox(Vector3.Zero, new Vector3(0.25f, 1.0f, 0.25f)),
        new BoundingBox(Vector3.Zero, new Vector3(1.0f, 0.25f, 0.25f)),
    };
    private int selectedAxis = -1;
    private bool leftMouseDown;
    private bool moved;

    private float offset;

    public TranslateGizmo()
    {
        meshFilename = "TranslateGizmo";
    }

    public override void Update(RenderCreateState state)
    {
        if (!IsVisible)
            return;

        BoundingBox = BoundingBox.FromSphere(new BoundingSphere(Transform.TranslationVector, renderProxy.Scale * 0.5f));

        float smallAxisAmount = 0.0625f * renderProxy.Scale;
        float largeAxisAmount = 0.5f * renderProxy.Scale;
        Vector3 translation = Transform.TranslationVector;

        axisBoundingBoxes[0] = new BoundingBox(new Vector3(-smallAxisAmount + translation.X, -smallAxisAmount + translation.Y, translation.Z), new Vector3(smallAxisAmount + translation.X, smallAxisAmount + translation.Y, largeAxisAmount + translation.Z));
        axisBoundingBoxes[1] = new BoundingBox(new Vector3(-smallAxisAmount + translation.X, translation.Y, -smallAxisAmount + translation.Z), new Vector3(smallAxisAmount + translation.X, largeAxisAmount + translation.Y, smallAxisAmount + translation.Z));
        axisBoundingBoxes[2] = new BoundingBox(new Vector3(-largeAxisAmount + translation.X, -smallAxisAmount + translation.Y, -smallAxisAmount + translation.Z), new Vector3(translation.X, smallAxisAmount + translation.Y, smallAxisAmount + translation.Z));

        renderProxy.UpdateSelectIndex(state, selectedAxis);
    }

    public override bool HitTest(Ray hitTestRay)
    {
        if (leftMouseDown)
            return true;

        if (base.HitTest(hitTestRay))
        {
            selectedAxis = -1;
            if (hitTestRay.Intersects(axisBoundingBoxes[0])) { selectedAxis = 0; }
            else if (hitTestRay.Intersects(axisBoundingBoxes[1])) { selectedAxis = 1; }
            else if (hitTestRay.Intersects(axisBoundingBoxes[2])) { selectedAxis = 2; }

            if (selectedAxis != -1)
            {
                System.Windows.Input.Mouse.OverrideCursor = System.Windows.Input.Cursors.SizeAll;
                return true;
            }
            else
            {
                System.Windows.Input.Mouse.OverrideCursor = null;
            }
        }

        return false;
    }

    public override bool MouseDown(int x, int y, Ray rayCast, MouseButton button)
    {
        if (button == MouseButton.Left && selectedAxis != -1)
        {
            leftMouseDown = true;

            if (selectedAxis == 0)
            {
                Vector3 outPosition;
                Plane axisPlane = new Plane(Transform.TranslationVector, Vector3.UnitX);
                rayCast.Intersects(ref axisPlane, out outPosition);
                offset = Transform.TranslationVector.Z - outPosition.Z;
            }
            else if (selectedAxis == 1)
            {
                Vector3 outPosition;
                Plane axisPlane = new Plane(Transform.TranslationVector, Vector3.UnitZ);
                rayCast.Intersects(ref axisPlane, out outPosition);
                offset = Transform.TranslationVector.Y - outPosition.Y;
            }
            else if (selectedAxis == 2)
            {
                Vector3 outPosition;
                Plane axisPlane = new Plane(Transform.TranslationVector, Vector3.UnitY);
                rayCast.Intersects(ref axisPlane, out outPosition);
                offset = Transform.TranslationVector.X - outPosition.X;
            }

            return true;
        }

        return false;
    }

    public override bool MouseMove(int x, int y, Ray rayCast)
    {
        if (leftMouseDown)
        {
            moved = true;
            if (selectedAxis == 0)
            {
                Matrix m = Transform;

                Vector3 outPosition;
                Plane axisPlane = new Plane(m.TranslationVector, Vector3.UnitX);
                rayCast.Intersects(ref axisPlane, out outPosition);

                m.TranslationVector = new Vector3(Transform.TranslationVector.X, Transform.TranslationVector.Y, outPosition.Z + offset);
                Transform = m;
            }
            else if (selectedAxis == 1)
            {
                Matrix m = Transform;

                Vector3 outPosition;
                Plane axisPlane = new Plane(m.TranslationVector, Vector3.UnitZ);
                rayCast.Intersects(ref axisPlane, out outPosition);

                m.TranslationVector = new Vector3(Transform.TranslationVector.X, outPosition.Y + offset, Transform.TranslationVector.Z);
                Transform = m;
            }
            else if (selectedAxis == 2)
            {
                Matrix m = Transform;

                Vector3 outPosition;
                Plane axisPlane = new Plane(m.TranslationVector, Vector3.UnitY);
                rayCast.Intersects(ref axisPlane, out outPosition);

                m.TranslationVector = new Vector3(outPosition.X + offset, Transform.TranslationVector.Y, Transform.TranslationVector.Z);
                Transform = m;
            }

            return true;
        }

        return false;
    }

    public override bool MouseUp(int x, int y, Ray rayCast, MouseButton button)
    {
        if (leftMouseDown)
        {
            bool gizmoMoved = moved;

            moved = false;
            leftMouseDown = false;
            selectedAxis = -1;
            System.Windows.Input.Mouse.OverrideCursor = null;

            return gizmoMoved;
        }

        return false;
    }
}

public class SelectedEntityChangedEventArgs : EventArgs
{
    public Entity Entity { get; private set; }

    public SelectedEntityChangedEventArgs(Entity entity)
    {
        Entity = entity;
    }
}

public class LevelEditorScreen : DeferredRenderScreen2
{
    // 对极小屏幕占比的实例进行统一裁剪，避免 CPU/GPU 在海量小物体上浪费开销
    // 经验值：0.002 ~= 占屏幕宽高 0.2%
    private const float MinScreenSizeCull = 0.002f;

    public bool ShowTaskWindow { get; set; }

    /// <summary>
    /// Set by LevelEditor at Initialize, used by MeshView etc. to get current level RootLayer (e.g. terrain entity).
    /// </summary>
    public IEditorProvider EditorProvider { get; set; }

    // @hack: so that entities have access to the camera. Primarily for sprites
    public static LevelEditorCamera EditorCamera { get; private set; }

    private List<MeshRenderInstance> sprites = [];

    private Queue<RenderAction> renderTasks = new Queue<RenderAction>();
    private List<RenderProxy> proxies = [];

    private TranslateGizmo translateGizmo;
    private BindableDepthTexture gizmoDepthTexture;

    public event EventHandler<SelectedEntityChangedEventArgs> SelectedEntityChanged;

    public LevelEditorScreen(bool groundVisibleByDefault = false)
    {
        GroundVisible = groundVisibleByDefault;
        translateGizmo = new TranslateGizmo();

        renderTasks.Enqueue(state =>
        {
            translateGizmo.CreateRenderProxy(state);

        });
    }

    public void AddEntity(Entity entity)
    {
        renderTasks.Enqueue((RenderCreateState state) =>
        {
            List<RenderProxy> newProxies = [];
            entity.CreateRenderProxy(newProxies, state);
            proxies.AddRange(newProxies);
        });
    }

    public void DeleteEntityFromRenderProxy(Entity entity)
    {
        renderTasks.Enqueue(state =>
        {
            var foundProxies = proxies.Where(rp => rp.OwnerEntity.Owner == entity).ToList();
            if (foundProxies == null)
                return;

            foreach (RenderProxy renderProxy in foundProxies)
            {
                proxies.Remove(renderProxy);
            }
        });
    }

    public override void Update(double timestep)
    {
        RenderMode = LevelEditorRenderingOptions.GetDebugRenderMode();

        base.Update(timestep);

        translateGizmo.Update(RenderCreateState);
        if (!translateGizmo.IsMoving)
        {
            if (selectedProxies.Count > 0 && selectedProxies[0].OwnerEntity.RequiresTransformUpdate)
            {
                if (selectedProxies[0].OwnerEntity.Owner is ISpatialEntity spatialEntity)
                {
                    translateGizmo.Transform = Matrix.Translation(spatialEntity.GetTransform().TranslationVector);
                }
            }
        }

        foreach (RenderProxy proxy in proxies)
            proxy.Update(RenderCreateState);
    }

    public void CaptureThumbnail(string path)
    {
        Render();

        {
            D3D11.Texture2D texture = Viewport.ColorBuffer;
            D3D11.Texture2DDescription description = texture.Description;

            D3D11.Texture2D textureCopy = new D3D11.Texture2D(Viewport.Device, new D3D11.Texture2DDescription
            {
                Width = (int)description.Width,
                Height = (int)description.Height,
                MipLevels = 1,
                ArraySize = 1,
                Format = description.Format,
                Usage = D3D11.ResourceUsage.Staging,
                SampleDescription = new SharpDX.DXGI.SampleDescription(1, 0),
                BindFlags = D3D11.BindFlags.None,
                CpuAccessFlags = D3D11.CpuAccessFlags.Read,
                OptionFlags = D3D11.ResourceOptionFlags.None
            });
            Viewport.Context.CopyResource(texture, textureCopy);

            DataStream dataStream;
            DataBox dataBox = Viewport.Context.MapSubresource(
                textureCopy,
                0,
                0,
                D3D11.MapMode.Read,
                D3D11.MapFlags.None,
                out dataStream);

            byte[] buffer = new byte[description.Width * description.Height * 4];
            for (int i = 0; i < description.Height; i++)
            {
                dataStream.Read(buffer, i * description.Width * 4, description.Width * 4);
                dataStream.Position += dataBox.RowPitch - (description.Width * 4);
            }
            for (int i = 3; i < buffer.Length; i += 4)
            {
                buffer[i] = 0xFF;
            }

            ImageUtils.SaveToPNG(description.Width, description.Height, buffer, new FileStream(path, FileMode.Create));

            Viewport.Context.UnmapSubresource(textureCopy, 0);
            textureCopy.Dispose();
        }
    }

    public override void Render()
    {
        if (renderTasks.Count > 0)
        {
            if (ShowTaskWindow)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    FrostyTaskWindow.Show("Preparing scene", "", (task) =>
                    {
                        ProcessRenderTasks();
                        ShowTaskWindow = false;
                    });
                });
            }
            else
            {
                ProcessRenderTasks();
            }
        }

        gizmoDepthTexture.Clear(Viewport.Context, true, true, 1.0f, 0);
        base.Render();
    }

    public override void CreateSizeDependentBuffers()
    {
        base.CreateSizeDependentBuffers();

        D3D11.Texture2DDescription description = new D3D11.Texture2DDescription
        {
            ArraySize = 1,
            Format = SharpDX.DXGI.Format.R24G8_Typeless,
            Width = Viewport.ViewportWidth,
            Height = Viewport.ViewportHeight,
            MipLevels = 1,
            SampleDescription = new SharpDX.DXGI.SampleDescription(1, 0),
            Usage = D3D11.ResourceUsage.Default
        };
        D3D11.DepthStencilViewDescription dsViewDesc = new D3D11.DepthStencilViewDescription
        {
            Dimension = D3D11.DepthStencilViewDimension.Texture2D,
            Format = SharpDX.DXGI.Format.D24_UNorm_S8_UInt,
            Texture2D = default(D3D11.DepthStencilViewDescription.Texture2DResource)
        };
        gizmoDepthTexture = new BindableDepthTexture(Viewport.Device, description, false, dsViewDesc);
    }

    public override void DisposeSizeDependentBuffers()
    {
        base.DisposeSizeDependentBuffers();
        gizmoDepthTexture.Dispose();
    }

    public override void DisposeBuffers()
    {
        base.DisposeBuffers();

        translateGizmo.Dispose();

        foreach (RenderProxy proxy in proxies)
            proxy.Dispose();

        proxies.Clear();
        selectedProxies.Clear();

        SolidColorMeshWrapper.DisposeSharedState();
    }

    public override void CreateBuffers()
    {
        if (camera == null)
        {
            camera = new LevelEditorCamera();
            camera.SetViewParams(new Vector3(0, 0, 0), new Vector3(0, 0, 0));

            SetCamera();
        }

        base.CreateBuffers();

        ShadowsEnabled = false;
        HBAOEnabled = false;
    }

    // @hack: so that entities have access to the camera. Primarily for sprites
    public void SetCamera()
    {
        EditorCamera = camera as LevelEditorCamera;
    }

    List<RenderProxy> selectedProxies = [];

    public void ClearSelection()
    {
        translateGizmo.IsVisible = false;
        renderTasks.Enqueue((state) =>
        {
            foreach (RenderProxy proxy in selectedProxies)
                proxy.SetSelected(state, false);
            selectedProxies.Clear();
        });

        MainWindow.UpdateSelectedEntity(null, this);
    }

    public void SelectEntity(Entity entity)
    {
        ClearSelection();

        IEnumerable<RenderProxy> foundProxies = proxies.Where(rp => rp.OwnerEntity.Owner == entity);
        if (foundProxies.Count() == 0)
            return;

        // Show translate controller (including StaticModelGroup children, modification now supported)
        if (entity is ISpatialEntity spatialEntity)
        {
            translateGizmo.Transform = Matrix.Translation(spatialEntity.GetTransform().TranslationVector);
            translateGizmo.IsVisible = true;
        }

        renderTasks.Enqueue((state) =>
        {
            selectedProxies.AddRange(foundProxies);
            foreach (RenderProxy proxy in selectedProxies)
                proxy.SetSelected(state, true);
        });

        // 2026/01/18
        // Change marker
        MainWindow.UpdateSelectedEntity(entity, this);
    }

    public void CenterOnSelection()
    {
        if (selectedProxies.Count == 0)
            return;

        BoundingBox totalBbox = new BoundingBox();
        int index = 0;

        foreach (RenderProxy proxy in selectedProxies)
        {
            if (index == 0) totalBbox = proxy.BoundingBox;
            else totalBbox = BoundingBox.Merge(totalBbox, proxy.BoundingBox);
            index++;
        }

        Vector3 center = totalBbox.Minimum + (totalBbox.Maximum - totalBbox.Minimum) * 0.5f;
        Vector3 offset = center + new Vector3(0, Math.Abs(totalBbox.Maximum.Y - totalBbox.Minimum.Y) / 1.25f, (totalBbox.Maximum - totalBbox.Minimum).Length() * 0.9f);

        (camera as FirstPersonCamera).SetViewParams(offset * new Vector3(-1, 1, 1), center * new Vector3(-1, 1, 1));
    }

    /// <summary>
    /// Called every frame
    /// </summary>
    public override List<MeshRenderInstance> CollectMeshInstances()
    {
        D3DUtils.BeginPerfEvent(Viewport.Context, "CollectMeshInstances_LevelEditor");

        LevelEditorCamera currentCamera = (LevelEditorCamera)camera;
        Matrix worldMatrix = currentCamera.WorldMatrix;

        BoundingFrustum cameraFrustum = BoundingFrustum.FromCamera(worldMatrix.TranslationVector, worldMatrix.Backward, worldMatrix.Down, currentCamera.FOV, currentCamera.GetNearClip(), currentCamera.GetFarClip(), currentCamera.AspectRatio);
        List<MeshRenderInstance> instancesInView = [];

        sprites.Clear();
        foreach (RenderProxy proxy in proxies)
        {
            float dist = (proxy.Transform.TranslationVector - worldMatrix.TranslationVector).Length();
            float width = cameraFrustum.GetWidthAtDepth(dist);
            float height = cameraFrustum.GetHeightAtDepth(dist);

            // 使用缓存的包围球，避免每帧为每个 Proxy 重新 FromBox
            BoundingSphere bSphere = proxy.BoundingSphere;
            float wratio = (bSphere.Radius * 2) / width;
            float hratio = (bSphere.Radius * 2) / height;
            float screenSize = (wratio > hratio) ? wratio : hratio;

            // 全局极小物体裁剪：不依赖具体 Proxy，只看屏幕占比
            if (screenSize < MinScreenSizeCull)
                continue;

            if (proxy.ShouldRender(dist, screenSize))
            {
                ContainmentType containmentType = cameraFrustum.Contains(proxy.BoundingBox);
                if (containmentType == ContainmentType.Contains || containmentType == ContainmentType.Intersects)
                {
                    proxy.CurrentDistanceToCamera = dist;

                    if (proxy is SpriteRenderProxy spriteRenderProxy)
                    {
                        sprites.Add(proxy.GetInstance(dist));

                        // Try to get model render instance
                        if (spriteRenderProxy.GetMeshRenderInstance(out MeshRenderInstance instance))
                        {
                            instancesInView.Add(instance);
                        }
                    }
                    else
                    {
                        instancesInView.Add(proxy.GetInstance(dist));
                    }
                }
            }
        }

        D3DUtils.EndPerfEvent(Viewport.Context);

        return instancesInView;
    }

    /// <summary>
    /// In solid color mode, SetMeshResPath mesh is added as bare MeshLodRenderable; shared LevelShader is set here before draw for pipeline switching with view mode.
    /// 对延迟渲染路径进行按距离排序渲染，减小过度绘制；其它路径沿用基础实现。
    /// </summary>
    protected override void RenderMeshes(MeshRenderPath renderPath, List<MeshRenderInstance> meshList)
    {
        // 仅在延迟渲染路径上做类型 + 距离排序以提升 Early-Z 与状态切换效率
        if (renderPath == MeshRenderPath.Deferred)
        {
            D3DUtils.BeginPerfEvent(Viewport.Context, "RenderMeshes_Sorted");
            {
                // 先按 RenderMesh 类型分组（Terrain -> Model -> 其它），再按距离从近到远排序
                int GetRenderCategory(MeshRenderInstance inst)
                {
                    if (inst.RenderMesh is TerrainRenderProxy) return 0;
                    if (inst.RenderMesh is ModelRenderProxy) return 1;
                    return 2;
                }

                meshList.Sort((a, b) =>
                {
                    int ca = GetRenderCategory(a);
                    int cb = GetRenderCategory(b);
                    if (ca != cb)
                        return ca.CompareTo(cb);

                    float da = (a.RenderMesh as RenderProxy)?.CurrentDistanceToCamera ?? 0.0f;
                    float db = (b.RenderMesh as RenderProxy)?.CurrentDistanceToCamera ?? 0.0f;
                    return da.CompareTo(db);
                });

                foreach (MeshRenderInstance mesh in meshList)
                {
                    D3DUtils.BeginPerfEvent(Viewport.Context, mesh.RenderMesh.DebugName);
                    {
                        Matrix transform = mesh.Transform;
                        transform.Transpose();

                        functionConstants.UpdateData(Viewport.Context, new FunctionConstants()
                        {
                            WorldMatrix = Matrix.Scaling(-1, 1, 1) * transform,
                            LightProbe1 = SHLightProbe[0],
                            LightProbe2 = SHLightProbe[1],
                            LightProbe3 = SHLightProbe[2],
                            LightProbe4 = SHLightProbe[3],
                            LightProbe5 = SHLightProbe[4],
                            LightProbe6 = SHLightProbe[5],
                            LightProbe7 = SHLightProbe[6],
                            LightProbe8 = SHLightProbe[7],
                            LightProbe9 = SHLightProbe[8],
                        });

                        Viewport.Context.VertexShader.SetConstantBuffer(1, functionConstants.Buffer);
                        Viewport.Context.PixelShader.SetConstantBuffer(1, functionConstants.Buffer);

                        if (mesh.RenderMesh is MeshLodRenderable)
                            SolidColorMeshWrapper.SetSharedShaderState(Viewport.Context, renderPath);

                        mesh.RenderMesh.Render(Viewport.Context, renderPath);
                    }
                    D3DUtils.EndPerfEvent(Viewport.Context);
                }
            }
            D3DUtils.EndPerfEvent(Viewport.Context);
        }
        else
        {
            // Forward / Shadows / Selection 路径保留基础行为（用于 Sprite、Gizmo 等）
            base.RenderMeshes(renderPath, meshList);
        }
    }

    protected List<MeshRenderInstance> GetSortedVisibleList()
    {
        LevelEditorCamera currentCamera = (LevelEditorCamera)camera;
        Matrix worldMatrix = currentCamera.WorldMatrix;

        BoundingFrustum cameraFrustum = BoundingFrustum.FromCamera(worldMatrix.TranslationVector, worldMatrix.Backward, worldMatrix.Down, currentCamera.FOV, currentCamera.GetNearClip(), currentCamera.GetFarClip(), currentCamera.AspectRatio);
        List<MeshRenderInstance> instancesInView = [];

        foreach (RenderProxy proxy in proxies)
        {
            float dist = (proxy.Transform.TranslationVector - worldMatrix.TranslationVector).Length();
            float width = cameraFrustum.GetWidthAtDepth(dist);
            float height = cameraFrustum.GetHeightAtDepth(dist);

            BoundingSphere bSphere = BoundingSphere.FromBox(proxy.BoundingBox);
            float wratio = (bSphere.Radius * 2) / width;
            float hratio = (bSphere.Radius * 2) / height;
            float screenSize = (wratio > hratio) ? wratio : hratio;

            if (proxy.ShouldRender(dist, screenSize))
            {
                ContainmentType containmentType = cameraFrustum.Contains(proxy.BoundingBox);
                if (containmentType == ContainmentType.Contains || containmentType == ContainmentType.Intersects)
                {
                    proxy.CurrentDistanceToCamera = dist;
                    instancesInView.Add(proxy.GetInstance(dist));
                }
            }
        }

        instancesInView.Sort((a, b) =>
        {
            return (a.RenderMesh as RenderProxy).CurrentDistanceToCamera.CompareTo((b.RenderMesh as RenderProxy).CurrentDistanceToCamera);
        });

        return instancesInView;
    }

    private struct MouseButtonData
    {
        public int X;
        public int Y;
        public MouseButton Button;
        public bool MouseDown;
    }
    private MouseButtonData mouseButtonData;

    public override void MouseDown(int x, int y, MouseButton button)
    {
        // Non-terrain edit mode: keep original Gizmo logic
        if (!TerrainEditState.IsTerrainEditModeEnabled)
        {
            if (translateGizmo.MouseDown(x, y, GetHitTestRay(x, y), button))
            {
                return;
            }
        }
        // Terrain edit mode: only allow Gizmo to receive mouse when TerrainEntity is selected (for vertex drag), otherwise ignore
        else
        {
            if (selectedProxies.Count > 0 && selectedProxies[0].OwnerEntity.Owner is Entities.TerrainEntity)
            {
                if (translateGizmo.MouseDown(x, y, GetHitTestRay(x, y), button))
                {
                    return;
                }
            }
        }

        if (button == MouseButton.Left)
        {
            if (!mouseButtonData.MouseDown)
            {
                mouseButtonData = new MouseButtonData() { X = x, Y = y, Button = button, MouseDown = true };
            }
        }

        base.MouseDown(x, y, button);
    }

    public override void MouseUp(int x, int y, MouseButton button)
    {
        // Non-terrain edit mode: keep original Gizmo end-drag logic (modify entity Transform)
        if (!TerrainEditState.IsTerrainEditModeEnabled &&
            translateGizmo.MouseUp(x, y, GetHitTestRay(x, y), button))
        {
            // Support StaticModelGroup child modification
            if (selectedProxies[0].OwnerEntity.Owner is ISpatialEntity spatialEntity)
            {
                Vector3 scale;
                Vector3 translation;
                Quaternion rotation;

                Matrix entityTransform = spatialEntity.GetLocalTransform();
                entityTransform.Decompose(out scale, out rotation, out translation);

                Matrix m = Matrix.Scaling(scale) * Matrix.RotationQuaternion(rotation) * Matrix.Translation(translateGizmo.Transform.TranslationVector);
                spatialEntity.SetTransform(m, suppressUpdate: false);

                foreach (RenderProxy proxy in selectedProxies)
                    proxy.OwnerEntity.RequiresTransformUpdate = true;
            }

            MainWindow.UpdateEntityTransform();

            return;
        }

        base.MouseUp(x, y, button);
        if (mouseButtonData.MouseDown)
        {
            if (x == mouseButtonData.X && y == mouseButtonData.Y && button == mouseButtonData.Button)
            {
                Ray ray = GetHitTestRay(x, y);

                List<MeshRenderInstance> visibleInstances = GetSortedVisibleList();
                List<Tuple<MeshRenderInstance, float>> hits = [];

                foreach (MeshRenderInstance instance in visibleInstances)
                {
                    RenderProxy instProxy = instance.RenderMesh as RenderProxy;
                    BoundingBox bbox = instProxy.BoundingBox;

                    Vector3 outPosition;
                    if (ray.Intersects(ref bbox, out outPosition))
                    {
                        if (instProxy.HitTest(ray, out outPosition))
                        {
                            hits.Add(new Tuple<MeshRenderInstance, float>(instance, (outPosition - (camera as LevelEditorCamera).WorldMatrix.TranslationVector).Length()));
                        }
                    }
                }

                RenderProxy proxy = null;
                RenderProxy prevSelection = selectedProxies.FirstOrDefault();

                if (hits.Count > 0)
                {
                    hits.Sort((a, b) => { return a.Item2.CompareTo(b.Item2); });
                    proxy = hits[0].Item1.RenderMesh as RenderProxy;

                    // In terrain edit mode and hit TerrainRenderProxy, do vertex picking
                    if (TerrainEditState.IsTerrainEditModeEnabled && proxy is Render.Proxies.TerrainRenderProxy terrainProxy)
                    {
                        // Only allow editing terrain owned by TerrainEntity
                        if (terrainProxy.OwnerEntity.Owner is Entities.TerrainEntity)
                        {
                            if (TerrainVertexPicker.TryPickVertex(ray, terrainProxy, out var sel))
                            {
                                TerrainEditState.CurrentVertex = sel;

                                // Place Gizmo at selected vertex position as edit handle
                                translateGizmo.Transform = Matrix.Translation(sel.WorldPosition);
                                translateGizmo.IsVisible = true;

                                // Notify MeshView to refresh display
                                MainWindow.UpdateEntityTransform();
                            }
                        }
                    }
                }

                Entity entityToSelect = (proxy != null)
                        ? proxy.OwnerEntity.Owner
                        : null;

                SelectedEntityChanged?.Invoke(this, new SelectedEntityChangedEventArgs(entityToSelect));
            }
        }

        mouseButtonData.MouseDown = false;
    }

    public override void MouseMove(int x, int y)
    {
        base.MouseMove(x, y);

        // Terrain edit mode: Gizmo drags current selected terrain vertex, not entity Transform
        if (TerrainEditState.IsTerrainEditModeEnabled)
        {
            if (TerrainEditState.CurrentVertex.HasValue &&
                selectedProxies.Count > 0 &&
                selectedProxies[0].OwnerEntity.Owner is Entities.TerrainEntity)
            {
                if (translateGizmo.MouseMove(x, y, GetHitTestRay(x, y)))
                {
                    // Update vertex height from Gizmo world position
                    var sel = TerrainEditState.CurrentVertex.Value;
                    var chunk = sel.Chunk;
                    if (chunk != null && sel.VertexIndex >= 0 && sel.VertexIndex < chunk.TerrainVertices.Count)
                    {
                        Vector3 gizmoPos = translateGizmo.Transform.TranslationVector;

                        // World -> Local
                        Matrix invWorld = Matrix.Invert(sel.Proxy.Transform);
                        Vector3 newLocalPos = Vector3.TransformCoordinate(gizmoPos, invWorld);

                        var verts = chunk.TerrainVertices;
                        var v = verts[sel.VertexIndex];
                        v.Position = newLocalPos;
                        verts[sel.VertexIndex] = v;

                        chunk.MarkVerticesDirty();

                        // Update current selection info and pending write-back record
                        sel.WorldPosition = gizmoPos;
                        TerrainEditState.CurrentVertex = sel;

                        int sampleIndex = TerrainVertexPicker.GetSampleIndexForVertex(sel.VertexIndex, chunk.Dim);
                        if (sampleIndex >= 0)
                        {
                            TerrainEditState.AddOrUpdateEdit(chunk.NodeId, sampleIndex, gizmoPos.Y);
                        }

                        // Notify MeshView to refresh UI (vertex height)
                        MainWindow.UpdateEntityTransform();
                    }
                }
            }

            return;
        }

        // Normal mode: keep original Gizmo behavior - modify entity Transform
        if (!translateGizmo.MouseMove(x, y, GetHitTestRay(x, y)))
        {
            Ray ray = GetHitTestRay(x, y);
            if (translateGizmo.HitTest(ray))
            {
                // do something
            }
        }
        else
        {
            if (selectedProxies.Count > 0 && selectedProxies[0].OwnerEntity.Owner is ISpatialEntity spatialEntity)
            {
                Vector3 scale;
                Vector3 translation;
                Quaternion rotation;

                Matrix entityTransform = spatialEntity.GetLocalTransform();
                entityTransform.Decompose(out scale, out rotation, out translation);

                Matrix m = Matrix.Scaling(scale) * Matrix.RotationQuaternion(rotation) * Matrix.Translation(translateGizmo.Transform.TranslationVector);
                spatialEntity.SetTransform(m, suppressUpdate: true);

                foreach (RenderProxy proxy in selectedProxies)
                    proxy.OwnerEntity.RequiresTransformUpdate = true;
            }

            MainWindow.UpdateEntityTransform();
        }
    }

    protected override void PostProcessEditorComposite()
    {
        base.PostProcessEditorComposite();

        sprites.Sort((a, b) =>
        {
            SpriteRenderProxy spriteA = a.RenderMesh as SpriteRenderProxy;
            SpriteRenderProxy spriteB = b.RenderMesh as SpriteRenderProxy;

            return spriteB.CurrentDistanceToCamera.CompareTo(spriteA.CurrentDistanceToCamera);
        });

        D3D11.DepthStencilView oldDsv;
        D3D11.RenderTargetView[] rts = Viewport.Context.OutputMerger.GetRenderTargets(6, out oldDsv);

        // Regular elements
        Viewport.Context.OutputMerger.SetRenderTargets(Viewport.DepthBufferDSV, rts);
        Viewport.Context.OutputMerger.DepthStencilState = D3DUtils.CreateDepthStencilState(true, D3D11.DepthWriteMask.Zero, depthComparison: D3D11.Comparison.LessEqual);
        Viewport.Context.OutputMerger.BlendState = D3DUtils.CreateBlendState(D3DUtils.CreateBlendStateRenderTarget(alphaBlend: true));

        Viewport.Context.VertexShader.SetConstantBuffer(0, viewConstants.Buffer);

        Viewport.Context.PixelShader.SetConstantBuffer(0, viewConstants.Buffer);
        Viewport.Context.PixelShader.SetShaderResource(0, normalBasisCubemapTexture.SRV);
        Viewport.Context.PixelShader.SetSampler(0, D3DUtils.CreateSamplerState(D3D11.TextureAddressMode.Clamp, filter: D3D11.Filter.MinMagMipPoint));

        RenderMeshes(MeshRenderPath.Forward, sprites);

        // Foreground elements
        Viewport.Context.OutputMerger.SetRenderTargets(gizmoDepthTexture.DSV, rts);
        Viewport.Context.OutputMerger.DepthStencilState = D3DUtils.CreateDepthStencilState(true, depthComparison: D3D11.Comparison.LessEqual);
        Viewport.Context.OutputMerger.BlendState = D3DUtils.CreateBlendState(D3DUtils.CreateBlendStateRenderTarget());

        List<MeshRenderInstance> instances = [];
        if (translateGizmo.IsVisible)
            instances.Add(translateGizmo.GetInstance());

        RenderMeshes(MeshRenderPath.Forward, instances);

        Viewport.Context.OutputMerger.SetRenderTargets(oldDsv, rts);
    }

    protected override void PostProcessSelectionOutline()
    {
        Viewport.Context.OutputMerger.SetRenderTargets(null, this.selectionOutlineTexture.RTV);
        Viewport.Context.OutputMerger.DepthStencilState = D3DUtils.CreateDepthStencilState(false, D3D11.DepthWriteMask.All);
        Viewport.Context.OutputMerger.BlendState = D3DUtils.CreateBlendState(D3DUtils.CreateBlendStateRenderTarget());
        Viewport.Context.Rasterizer.State = D3DUtils.CreateRasterizerState(D3D11.CullMode.None);
        Viewport.Context.InputAssembler.SetIndexBuffer(null, SharpDX.DXGI.Format.Unknown, 0);
        Viewport.Context.InputAssembler.SetVertexBuffers(0, new D3D11.VertexBufferBinding());
        Viewport.Context.InputAssembler.InputLayout = null;
        Viewport.Context.VertexShader.Set(vsFullscreenQuad);
        Viewport.Context.VertexShader.SetConstantBuffer(0, commonConstants.Buffer);
        Viewport.Context.PixelShader.Set(psResolve);
        Viewport.Context.PixelShader.SetShaderResources(0, new D3D11.ShaderResourceView[]
        {
            finalColorTexture.SRV,
            selectionDepthTexture.SRV
        });
        Viewport.Context.PixelShader.SetSampler(0, D3DUtils.CreateSamplerState(D3D11.TextureAddressMode.Clamp));
        Viewport.Context.Draw(6, 0);
    }

    private Ray GetHitTestRay(int x, int y)
    {
        if (camera == null) return new Ray();
        Matrix viewProj = camera.GetViewProjMatrix();
        Ray ray = Ray.GetPickRay(x, y, new Viewport(0, 0, Viewport.ViewportWidth, Viewport.ViewportHeight, camera.GetNearClip(), camera.GetFarClip()), viewProj);

        ray.Position.X *= -1.0f;

        ray.Direction = (ray.Position - (camera.GetEyePt() * new Vector3(-1, 1, 1)));
        ray.Direction.Normalize();

        return ray;
    }

    private void ProcessRenderTasks()
    {
        while (renderTasks.Count > 0)
        {
            RenderAction action = renderTasks.Dequeue();
            action.Invoke(RenderCreateState);
        }
    }
}
