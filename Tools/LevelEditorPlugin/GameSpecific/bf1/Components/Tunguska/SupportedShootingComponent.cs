
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SupportedShootingComponentData))]
public class SupportedShootingComponent : GameComponent, IEntityData<FrostySdk.Ebx.SupportedShootingComponentData>
{
    public new FrostySdk.Ebx.SupportedShootingComponentData Data => data as FrostySdk.Ebx.SupportedShootingComponentData;
    public override string DisplayName => "SupportedShootingComponent";

    public SupportedShootingComponent(FrostySdk.Ebx.SupportedShootingComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

