
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ExplosivesTrackingComponentData))]
public class ExplosivesTrackingComponent : GameComponent, IEntityData<FrostySdk.Ebx.ExplosivesTrackingComponentData>
{
    public new FrostySdk.Ebx.ExplosivesTrackingComponentData Data => data as FrostySdk.Ebx.ExplosivesTrackingComponentData;
    public override string DisplayName => "ExplosivesTrackingComponent";

    public ExplosivesTrackingComponent(FrostySdk.Ebx.ExplosivesTrackingComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

