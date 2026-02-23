using Frosty.Core;
using Frosty.Core.Managers;
using Frosty.Core.Viewport;
//using FrostySdk.Ebx;
using FrostySdk.IO;
using LevelEditorPlugin.BF1Core.Enums;
using LevelEditorPlugin.BF1Core.Native;
using LevelEditorPlugin.BF1Core.Utils;
using LevelEditorPlugin.Entities;
using LevelEditorPlugin.Managers;
using LevelEditorPlugin.Options;
using LevelEditorPlugin.Resources;
using LevelEditorPlugin.Screens;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LevelEditorPlugin.BF1Core.Views;

/// <summary>
/// Interaction logic for MeshView.xaml
/// </summary>
public partial class MeshView : UserControl
{
    /// <summary>
    /// Entity selected in 3D window
    /// </summary>
    public Entity Entity { get; private set; }
    /// <summary>
    /// Level editor screen
    /// </summary>
    public LevelEditorScreen LevelEditorScreen { get; private set; }

    /// <summary>
    /// Copy model direction
    /// </summary>
    private CopyDirection copyDirection = CopyDirection.ZAxisAdd;

    private static readonly string[] ViewModeItems =
    [
        "Solid Color",
        "Default Lit",
        "Wireframe",
        "BaseColor",
        "SpecularColor",
        "Normals",
        "MaterialAO",
        "Smoothness",
        "Metallic",
        "Reflectance"
    ];

    public MeshView()
    {
        InitializeComponent();

        HotKey.KeyDownEvent += HotKey_KeyDownEvent;
        HavokPhysicsData.PendingCommitChanged += OnPendingCommitChanged;

        ComboBox_ViewMode.ItemsSource = ViewModeItems;
        ComboBox_ViewMode.SelectedIndex = Math.Min(LevelEditorRenderingOptions.ViewModeIndex, ViewModeItems.Length - 1);

        // Initialize terrain edit mode UI
        if (CheckBox_TerrainEditMode != null)
            CheckBox_TerrainEditMode.IsChecked = BF1Core.Utils.TerrainEditState.IsTerrainEditModeEnabled;
    }

    private void OnPendingCommitChanged()
    {
        Dispatcher.InvokeAsync(UpdateWriteHavokButtonState);
    }

    private void ComboBox_ViewMode_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        if (ComboBox_ViewMode.SelectedIndex >= 0)
        {
            LevelEditorRenderingOptions.ViewModeIndex = ComboBox_ViewMode.SelectedIndex;
        }
    }

    /// <summary>
    /// Handle hotkey press events
    /// </summary>
    private void HotKey_KeyDownEvent(Keys key)
    {
        if (UndoManager.Instance == null) return;

        this.Dispatcher.Invoke(() =>
        {
            switch (key)
            {
                case Keys.F1:
                    Button_SnapToCam_Click(null, null);
                    break;
                case Keys.F5:
                    Button_CopyMeshToCamera_Click(null, null);
                    break;
            }
        });
    }

    /// <summary>
    /// Update selected entity info
    /// </summary>
    public void UpdateSelectedEntity(Entity entity, LevelEditorScreen screen)
    {
        Entity = entity;
        LevelEditorScreen = screen;

        UpdateUI();
    }

    /// <summary>
    /// Update UI
    /// </summary>
    public void UpdateUI()
    {
        if (Entity == null)
        {
            TextBlock_EntityName.Text = "Null";
            TextBlock_LayerName.Text = "Null";

            TextBox_TransX.Text = "0.00000";
            TextBox_TransY.Text = "0.00000";
            TextBox_TransZ.Text = "0.00000";

            TextBox_RotateX.Text = "0.00000";
            TextBox_RotateY.Text = "0.00000";
            TextBox_RotateZ.Text = "0.00000";

            TextBox_ScaleX.Text = "1.00000";
            TextBox_ScaleY.Text = "1.00000";
            TextBox_ScaleZ.Text = "1.00000";

            UpdateWriteHavokButtonState();
        }
        else
        {
            TextBlock_EntityName.Text = Entity.DisplayName;
            TextBlock_LayerName.Text = Entity.Layer?.LayerName;

            if (Entity is ISpatialEntity spatialEntity)
            {
                var matrix = spatialEntity.GetLocalTransform();
                _ = matrix.Decompose(out Vector3 scale, out _, out Vector3 translation);
                Vector3 euler = SharpDXUtils.ExtractEulerAngles(matrix);

                TextBox_TransX.Text = translation.X.ToString("0.00000");
                TextBox_TransY.Text = translation.Y.ToString("0.00000");
                TextBox_TransZ.Text = translation.Z.ToString("0.00000");

                TextBox_RotateX.Text = euler.X.ToString("0.00000");
                TextBox_RotateY.Text = euler.Y.ToString("0.00000");
                TextBox_RotateZ.Text = euler.Z.ToString("0.00000");

                TextBox_ScaleX.Text = scale.X.ToString("0.00000");
                TextBox_ScaleY.Text = scale.Y.ToString("0.00000");
                TextBox_ScaleZ.Text = scale.Z.ToString("0.00000");
            }

            UpdateWriteHavokButtonState();
        }

        // Update terrain edit area UI (e.g. current selected vertex height)
        UpdateTerrainVertexUI();
    }

    /// <summary>
    /// Update enabled state of the "Write Havok Transform to Res" button.
    /// </summary>
    private void UpdateWriteHavokButtonState()
    {
        if (Button_WriteHavokTransformsToRes != null)
        {
            Button_WriteHavokTransformsToRes.IsEnabled = HavokPhysicsData.HasAnyPendingCommit;
        }
    }

    /// <summary>
    /// Update vertex height display in MeshView based on current terrain edit state and selected vertex.
    /// </summary>
    private void UpdateTerrainVertexUI()
    {
        if (TextBox_SelectedVertexHeight == null || TextBox_NewVertexHeight == null)
            return;

        var selOpt = BF1Core.Utils.TerrainEditState.CurrentVertex;
        if (selOpt.HasValue && BF1Core.Utils.TerrainEditState.IsTerrainEditModeEnabled)
        {
            var sel = selOpt.Value;
            TextBox_SelectedVertexHeight.Text = sel.WorldPosition.Y.ToString("0.00000");

            // If new height is empty, default to current height for fine-tuning
            if (string.IsNullOrWhiteSpace(TextBox_NewVertexHeight.Text))
                TextBox_NewVertexHeight.Text = sel.WorldPosition.Y.ToString("0.00000");
        }
        else
        {
            TextBox_SelectedVertexHeight.Text = string.Empty;
            // Don't force clear NewVertexHeight; allows user to repeatedly apply same target height to multiple points
        }
    }

    /// <summary>
    /// Modify model coordinates in real-time
    /// </summary>
    private void TextBox_Transform_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
            return;

        try
        {
            if (Entity is ISpatialEntity spatialEntity)
            {
                var matrix = spatialEntity.GetLocalTransform();
                _ = matrix.Decompose(out Vector3 scale, out _, out Vector3 translation);
                var euler = SharpDXUtils.ExtractEulerAngles(matrix);

                if (float.TryParse(TextBox_TransX.Text, out float value)) translation.X = value;
                if (float.TryParse(TextBox_TransY.Text, out value)) translation.Y = value;
                if (float.TryParse(TextBox_TransZ.Text, out value)) translation.Z = value;

                if (float.TryParse(TextBox_RotateX.Text, out value)) euler.X = value;
                if (float.TryParse(TextBox_RotateY.Text, out value)) euler.Y = value;
                if (float.TryParse(TextBox_RotateZ.Text, out value)) euler.Z = value;

                if (float.TryParse(TextBox_ScaleX.Text, out value)) scale.X = value;
                if (float.TryParse(TextBox_ScaleY.Text, out value)) scale.Y = value;
                if (float.TryParse(TextBox_ScaleZ.Text, out value)) scale.Z = value;

                // Normalize Euler angles
                euler.X = CoreUtil.NormalizeAngle(euler.X);
                euler.Y = CoreUtil.NormalizeAngle(euler.Y);
                euler.Z = CoreUtil.NormalizeAngle(euler.Z);

                TextBox_RotateX.Text = euler.X.ToString("0.00000");
                TextBox_RotateY.Text = euler.Y.ToString("0.00000");
                TextBox_RotateZ.Text = euler.Z.ToString("0.00000");

                var degToRad = (float)(Math.PI / 180.0);
                var quaternion = SharpDXUtils.CreateFromEulerAngles(euler.X * degToRad, euler.Y * degToRad, euler.Z * degToRad);

                var newMatrix = Matrix.Scaling(scale.X, scale.Y, scale.Z) *
                    Matrix.RotationQuaternion(quaternion) *
                    Matrix.Translation(translation);

                spatialEntity.SetTransform(newMatrix, true);
                spatialEntity.RequiresTransformUpdate = true;

                UpdateWriteHavokButtonState();
            }
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Exception while modifying selected model coordinates: {ex.Message}");
        }
    }

    /// <summary>
    /// TextBox mouse wheel event
    /// </summary>
    private void TextBox_Transform_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
            return;

        if (sender is TextBox textBox)
        {
            if (float.TryParse(textBox.Text, out float value))
            {
                float step;
                if (textBox.Name.StartsWith("TextBox_Rotate"))
                    step = 1.0f;
                else if (textBox.Name.StartsWith("TextBox_Scale"))
                    step = 0.1f;
                else
                    step = 0.1f; // translation

                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                    step *= 10.0f;
                if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                    step *= 0.1f;

                value += (e.Delta > 0) ? step : -step;

                textBox.Text = value.ToString("0.00000");

                if (CheckBox_UniformScale.IsChecked == true && textBox.Name.StartsWith("TextBox_Scale"))
                {
                    TextBox_ScaleX.Text = value.ToString("0.00000");
                    TextBox_ScaleY.Text = value.ToString("0.00000");
                    TextBox_ScaleZ.Text = value.ToString("0.00000");
                }

                e.Handled = true;
            }
        }
    }

    /// <summary>
    /// Slider mouse wheel event
    /// </summary>
    private void Slider_Count_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (sender is Slider slider)
        {
            var value = slider.Value;

            if (value < slider.Minimum)
            {
                slider.Value = slider.Minimum;
                return;
            }
            if (value > slider.Maximum)
            {
                slider.Value = slider.Maximum;
                return;
            }

            var step = slider.SmallChange;
            value += (e.Delta > 0) ? step : -step;
            slider.Value = value;

            e.Handled = true;
        }
    }

    /// <summary>
    /// Move model to camera
    /// </summary>
    private void Button_SnapToCam_Click(object sender, RoutedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
        {
            App.Logger.LogWarning("Current Entity is Null");
            return;
        }
        var camera = LevelEditorScreen.EditorCamera;
        if (camera == null)
        {
            App.Logger.LogWarning("Current level editor camera not found");
            return;
        }

        Button_SnapToCam.IsEnabled = false;

        if (Entity is ISpatialEntity spatialEntity)
        {
            var cameraPos = camera.WorldMatrix.TranslationVector;

            var matrix = spatialEntity.GetLocalTransform();
            _ = matrix.Decompose(out Vector3 scale, out Quaternion quaternion, out _);

            var newMatrix = Matrix.Scaling(scale) *
                Matrix.RotationQuaternion(quaternion) *
                Matrix.Translation(cameraPos);
            spatialEntity.SetTransform(newMatrix, true);
            spatialEntity.RequiresTransformUpdate = true;
        }

        Button_SnapToCam.IsEnabled = true;

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Reset rotation
    /// </summary>
    private void Button_ResetRotate_Click(object sender, RoutedEventArgs e)
    {
        TextBox_RotateX.Text = "0.0";
        TextBox_RotateY.Text = "0.0";
        TextBox_RotateZ.Text = "0.0";
    }

    /// <summary>
    /// Reset scale
    /// </summary>
    private void Button_ResetScale_Click(object sender, RoutedEventArgs e)
    {
        TextBox_ScaleX.Text = "1.0";
        TextBox_ScaleY.Text = "1.0";
        TextBox_ScaleZ.Text = "1.0";
    }

    /// <summary>
    /// Copy model to camera
    /// </summary>
    private async void Button_CopyMeshToCamera_Click(object sender, RoutedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
        {
            App.Logger.LogWarning("Current Entity is Null");
            return;
        }
        if (LevelEditorScreen == null)
        {
            App.Logger.LogWarning("Current LevelEditorScreen is Null");
            return;
        }

        Button_CopyMeshToCamera.IsEnabled = false;
        App.Logger.Log("=================================");

        App.Logger.Log("Starting copy model to camera...");

        try
        {
            await MeshUtil.CopySelectedMesh(new CopyMeshOption()
            {
                Entity = Entity,
                LevelEditorScreen = LevelEditorScreen,
                IsCopyToCamera = true
            });
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Exception while copying model to camera: {ex.Message}");
        }
        finally
        {
            App.Logger.Log("Copy model to camera operation completed");
        }

        App.Logger.Log("=================================");
        Button_CopyMeshToCamera.IsEnabled = true;

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Delete selected entity
    /// </summary>
    private async void Button_DeleteSelectedEntity_Click(object sender, RoutedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
        {
            App.Logger.LogWarning("Current Entity is Null");
            return;
        }
        if (LevelEditorScreen == null)
        {
            App.Logger.LogWarning("Current LevelEditorScreen is Null");
            return;
        }

        Button_DeleteSelectedEntity.IsEnabled = false;
        App.Logger.Log("=================================");

        App.Logger.Log("Starting delete selected entity...");

        try
        {
            await MeshUtil.DeleteSelectedMesh(new DeleteMeshOption()
            {
                Entity = Entity,
                LevelEditorScreen = LevelEditorScreen
            });
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Exception while deleting selected entity: {ex.Message}");
        }
        finally
        {
            App.Logger.Log("Delete selected entity operation completed");
        }

        App.Logger.Log("=================================");
        Button_DeleteSelectedEntity.IsEnabled = true;

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// One-click flatten terrain: modify binary height data and write back to Res and Chunk, without viewport update.
    /// </summary>
    private void Button_FlattenTerrain_Click(object sender, RoutedEventArgs e)
    {
        if (LevelEditorScreen?.EditorProvider?.RootLayer == null)
        {
            App.Logger.LogWarning("Unable to get current level (please ensure map is opened in level editor)");
            return;
        }

        List<Entity> entities = [];
        LevelEditorScreen.EditorProvider.RootLayer.CollectEntities(entities);
        TerrainEntity terrainEntity = entities.Find(e => e is TerrainEntity) as TerrainEntity;
        if (terrainEntity == null)
        {
            App.Logger.LogWarning("Current level has no terrain entity");
            return;
        }

        Button_FlattenTerrain.IsEnabled = false;
        App.Logger.Log("=================================");
        App.Logger.Log("Starting one-click flatten terrain...");

        try
        {
            float worldHeightY = 0.0f;
            if (TextBox_FlattenTerrainHeight != null &&
                float.TryParse(TextBox_FlattenTerrainHeight.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float parsed))
            {
                worldHeightY = parsed;
            }

            bool ok = TerrainFlattenHelper.FlattenTerrain(terrainEntity, worldHeightY);
            if (ok)
                App.Logger.Log("One-click flatten terrain completed; please manually reopen map to view changes");
            else
                App.Logger.LogWarning("One-click flatten terrain was not executed or failed");
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"One-click flatten terrain exception: {ex.Message}");
        }
        finally
        {
            App.Logger.Log("=================================");
            Button_FlattenTerrain.IsEnabled = true;
        }

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Toggle terrain edit mode.
    /// </summary>
    private void CheckBox_TerrainEditMode_Click(object sender, RoutedEventArgs e)
    {
        bool enabled = CheckBox_TerrainEditMode.IsChecked == true;
        BF1Core.Utils.TerrainEditState.IsTerrainEditModeEnabled = enabled;

        if (!enabled)
        {
            BF1Core.Utils.TerrainEditState.ClearSelection();
        }

        UpdateTerrainVertexUI();
        App.Logger.Log(enabled ? "Terrain edit mode enabled" : "Terrain edit mode disabled");
    }

    /// <summary>
    /// Apply new world height to currently selected terrain vertices (realtime rendering only, not written to res/chunk).
    /// </summary>
    private void Button_ApplyVertexHeight_Click(object sender, RoutedEventArgs e)
    {
        if (!BF1Core.Utils.TerrainEditState.IsTerrainEditModeEnabled)
        {
            App.Logger.LogWarning("Terrain edit mode is not enabled; cannot edit terrain vertices");
            return;
        }

        var selOpt = BF1Core.Utils.TerrainEditState.CurrentVertex;
        if (!selOpt.HasValue)
        {
            App.Logger.LogWarning("No terrain vertex is currently selected");
            return;
        }

        if (!float.TryParse(TextBox_NewVertexHeight.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float newWorldY))
        {
            App.Logger.LogWarning("Unable to parse new world height; please enter a valid number");
            return;
        }

        var sel = selOpt.Value;
        var chunk = sel.Chunk;
        if (chunk == null || sel.VertexIndex < 0 || sel.VertexIndex >= chunk.TerrainVertices.Count)
        {
            App.Logger.LogWarning("Current vertex selection is invalid");
            return;
        }

        // World -> Local
        Vector3 worldPos = sel.WorldPosition;
        worldPos.Y = newWorldY;

        Matrix invWorld = Matrix.Invert(sel.Proxy.Transform);
        Vector3 newLocalPos = Vector3.TransformCoordinate(worldPos, invWorld);

        var verts = chunk.TerrainVertices;
        var v = verts[sel.VertexIndex];
        v.Position = newLocalPos;
        verts[sel.VertexIndex] = v;

        chunk.MarkVerticesDirty();

        // Update cached WorldPosition for UI display
        sel.WorldPosition = worldPos;
        BF1Core.Utils.TerrainEditState.CurrentVertex = sel;

        // Record pending height edits (based on Heightfield node Id + sample index + target world height)
        int sampleIndex = BF1Core.Utils.TerrainVertexPicker.GetSampleIndexForVertex(sel.VertexIndex, chunk.Dim);
        if (sampleIndex >= 0)
        {
            BF1Core.Utils.TerrainEditState.AddOrUpdateEdit(chunk.NodeId, sampleIndex, newWorldY);
        }

        UpdateTerrainVertexUI();

        App.Logger.Log($"Vertex height modified to world Y={newWorldY:0.00000} (realtime rendering only, not written to res/chunk)");
    }

    /// <summary>
    /// Write terrain height to Res/Chunk (placeholder; no actual write, prompt only).
    /// </summary>
    private void Button_CommitTerrainHeights_Click(object sender, RoutedEventArgs e)
    {
        if (LevelEditorScreen?.EditorProvider?.RootLayer == null)
        {
            App.Logger.LogWarning("Unable to get current level (please ensure map is opened in level editor)");
            return;
        }

        // Find TerrainEntity for current level
        List<Entity> entities = [];
        LevelEditorScreen.EditorProvider.RootLayer.CollectEntities(entities);
        TerrainEntity terrainEntity = entities.Find(ei => ei is TerrainEntity) as TerrainEntity;
        if (terrainEntity == null)
        {
            App.Logger.LogWarning("Current level has no terrain entity; cannot write terrain height");
            return;
        }

        App.Logger.Log("=================================");
        App.Logger.Log("Starting to write terrain vertex edits from current session to Chunk...");

        try
        {
            TerrainHeightCommitHelper.CommitPendingEdits(terrainEntity);
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Failed to write terrain to Chunk: {ex.Message}");
        }
        finally
        {
            App.Logger.Log("Write terrain to Chunk operation completed (first version only handles non-persistent nodes).");
            App.Logger.Log("=================================");
        }

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Mouse wheel adjusts new world height of current selected vertex and immediately applies to vertex.
    /// </summary>
    private void TextBox_NewVertexHeight_MouseWheel(object sender, MouseWheelEventArgs e)
    {
        if (!TerrainEditState.IsTerrainEditModeEnabled)
            return;

        if (!TerrainEditState.CurrentVertex.HasValue)
            return;

        if (!float.TryParse(TextBox_NewVertexHeight.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float value))
            value = TerrainEditState.CurrentVertex.Value.WorldPosition.Y;

        float step = 0.1f;
        if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
            step *= 10.0f;

        value += (e.Delta > 0) ? step : -step;

        TextBox_NewVertexHeight.Text = value.ToString("0.00000", System.Globalization.CultureInfo.InvariantCulture);

        // Apply to vertex immediately on wheel for real-time preview
        Button_ApplyVertexHeight_Click(null, null);

        e.Handled = true;
    }

    /// <summary>
    /// Write modified Havok transforms from StaticModelGroup back to resources via ModifyRes.
    /// </summary>
    private void Button_WriteHavokTransformsToRes_Click(object sender, RoutedEventArgs e)
    {
        if (!HavokPhysicsData.HasAnyPendingCommit)
        {
            App.Logger.Log("No pending Havok Transform modifications to write back");
            return;
        }

        Button_WriteHavokTransformsToRes.IsEnabled = false;
        int count = HavokPhysicsData.CommitAllPendingToRes();
        App.Logger.Log($"Wrote {count} Havok physics resource Transform modifications back to Res");
        Button_WriteHavokTransformsToRes.IsEnabled = false; // Disabled after write; no pending items
        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Fix OBBCollision scale
    /// </summary>
    private void Button_FixOBBCollisionScale_Click(object sender, RoutedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
        {
            App.Logger.LogWarning("Current Entity is Null");
            return;
        }
        if (!(Entity is OBBCollisionEntity))
        {
            App.Logger.LogWarning("Current Entity is not OBBCollisionEntity or PamOBBCollisionEntity type");
            return;
        }

        Button_FixOBBCollisionScale.IsEnabled = false;
        App.Logger.Log("=================================");

        App.Logger.Log("Starting fix OBBCollision scale...");

        try
        {
            var ebxAssetEnity = App.AssetManager.GetEbxEntry(Entity.FileGuid);
            EbxAsset ebxAsset = LoadedAssetManager.Instance.GetEbxAsset(Entity.FileGuid);
            dynamic rootObject = ebxAsset.RootObject;

            foreach (dynamic itemRef in rootObject.Objects)
            {
                Guid guid = CoreUtil.GetInternalClassGuid(itemRef);
                if (guid == Entity.InstanceGuid)
                {
                    var obbCollision = itemRef.Internal;

                    // FrostySdk.Ebx.LinearTransform
                    Matrix matrix = SharpDXUtils.FromLinearTransform(obbCollision.Transform);
                    _ = matrix.Decompose(out Vector3 scale, out Quaternion quaternion, out Vector3 translation);

                    // Break loop when first is found
                    obbCollision.HalfExtents.x *= scale.X;
                    obbCollision.HalfExtents.y *= scale.Y;
                    obbCollision.HalfExtents.z *= scale.Z;

                    var newMatrix = Matrix.Scaling(1.0f, 1.0f, 1.0f) *
                        Matrix.RotationQuaternion(quaternion) *
                        Matrix.Translation(translation);

                    // FrostySdk.Ebx.LinearTransform
                    obbCollision.Transform = Entity.MakeLinearTransform(newMatrix);
                    break;
                }
            }

            // Update and save changes
            ebxAsset.Update();
            App.AssetManager.ModifyEbx(ebxAssetEnity.Name, ebxAsset);
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Exception while fixing OBBCollision scale: {ex.Message}");
        }
        finally
        {
            UpdateUI();
            TextBox_Transform_TextChanged(null, null);

            App.Logger.Log("Fix OBBCollision scale operation completed");
        }

        App.Logger.Log("=================================");
        Button_FixOBBCollisionScale.IsEnabled = true;

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Select copy model direction
    /// </summary>
    private void RadioButton_XYZAxis_Checked(object sender, RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton)
        {
            switch (radioButton.Name)
            {
                case "RadioButton_XAxisAdd":
                    copyDirection = CopyDirection.XAxisAdd;
                    break;
                case "RadioButton_YAxisAdd":
                    copyDirection = CopyDirection.YAxisAdd;
                    break;
                case "RadioButton_ZAxisAdd":
                    copyDirection = CopyDirection.ZAxisAdd;
                    break;
                case "RadioButton_XAxisSub":
                    copyDirection = CopyDirection.XAxisSub;
                    break;
                case "RadioButton_YAxisSub":
                    copyDirection = CopyDirection.YAxisSub;
                    break;
                case "RadioButton_ZAxisSub":
                    copyDirection = CopyDirection.ZAxisSub;
                    break;
            }
        }
    }

    /// <summary>
    /// Print selection info
    /// </summary>
    private void Button_PrintSelectInfo_Click(object sender, RoutedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
        {
            App.Logger.LogWarning("Current Entity is Null");
            return;
        }

        Button_PrintSelectInfo.IsEnabled = false;
        App.Logger.Log("=================================");

        App.Logger.Log($"Entity.DisplayName: {Entity.DisplayName}");
        App.Logger.Log($"Entity.Layer.LayerName: {Entity.Layer.LayerName}");
        App.Logger.Log($"Entity.FileGuid: {Entity.FileGuid}");
        App.Logger.Log($"Entity.InstanceGuid: {Entity.InstanceGuid}");

        App.Logger.Log("----------");
        App.Logger.Log($"Entity.Parent.DisplayName: {Entity.Parent?.DisplayName}");
        App.Logger.Log($"Entity.Owner.DisplayName: {Entity.Owner?.DisplayName}");

        App.Logger.Log("----------");
        App.Logger.Log($"Entity.Parent.Layer.LayerName: {Entity.Parent?.Layer?.LayerName}");
        App.Logger.Log($"Entity.Owner.Layer.LayerName: {Entity.Owner?.Layer?.LayerName}");

        App.Logger.Log("----------");
        var ebxAssetEnity = App.AssetManager.GetEbxEntry(Entity.FileGuid);
        App.Logger.Log($"EbxAssetEnity Name: {ebxAssetEnity.Name}");

        if (Entity is ISpatialEntity spatialEntity)
        {
            App.Logger.Log("----------");

            var matrix1 = spatialEntity.GetTransform();
            App.Logger.Log($"Entity GetTransform: \t\t{matrix1}");

            var matrix2 = spatialEntity.GetLocalTransform();
            App.Logger.Log($"Entity GetLocalTransform: \t{matrix2}");
        }

        if (Entity is StaticModelGroupElementEntity staticModelGroupElementEntity)
        {
            App.Logger.Log("----------");

            App.Logger.Log($"Current Entity is StaticModelGroupElementEntity type");
            var transform = staticModelGroupElementEntity.Data.Transform;
            App.Logger.Log(transform.ToString());
        }

        App.Logger.Log("=================================");
        Button_PrintSelectInfo.IsEnabled = true;

        CoreUtil.PlayAudio();
    }

    /// <summary>
    /// Copy model
    /// </summary>
    private async void Button_CopyMesh_Click(object sender, RoutedEventArgs e)
    {
        if (UndoManager.Instance == null) return;

        if (Entity == null)
        {
            App.Logger.LogWarning("Current Entity is Null");
            return;
        }
        if (LevelEditorScreen == null)
        {
            App.Logger.LogWarning("Current LevelEditorScreen is Null");
            return;
        }

        Button_CopyMesh.IsEnabled = false;
        UniformGrid_CopyDirection.IsEnabled = false;
        ProgressBar_TaskState.IsIndeterminate = true;
        App.Logger.Log("=================================");

        var stopwatch = new Stopwatch();
        stopwatch.Start();
        App.Logger.Log("Starting copy selected mesh...");

        try
        {
            // Copy count
            var count = (int)Slider_CopyCount.Value;
            // Copy spacing
            var step = (float)Slider_CopyStep.Value;

            await MeshUtil.CopySelectedMesh(new CopyMeshOption()
            {
                Entity = Entity,
                LevelEditorScreen = LevelEditorScreen,
                IsCopyToCamera = false,
                Count = count,
                Step = step,
                CopyDirection = copyDirection
            });
        }
        catch (Exception ex)
        {
            App.Logger.LogError($"Exception while copying selected mesh: {ex.Message}");
        }
        finally
        {
            stopwatch.Stop();
            App.Logger.Log($"Copy selected mesh operation completed, elapsed: {stopwatch.ElapsedMilliseconds}ms");
        }

        App.Logger.Log("=================================");
        Button_CopyMesh.IsEnabled = true;
        UniformGrid_CopyDirection.IsEnabled = true;
        ProgressBar_TaskState.IsIndeterminate = false;

        CoreUtil.PlayAudio();
    }
}
