
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MissileSurfaceAdaptionComponentData))]
public class MissileSurfaceAdaptionComponent : GameComponent, IEntityData<FrostySdk.Ebx.MissileSurfaceAdaptionComponentData>
{
    public new FrostySdk.Ebx.MissileSurfaceAdaptionComponentData Data => data as FrostySdk.Ebx.MissileSurfaceAdaptionComponentData;
    public override string DisplayName => "MissileSurfaceAdaptionComponent";

    public MissileSurfaceAdaptionComponent(FrostySdk.Ebx.MissileSurfaceAdaptionComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

