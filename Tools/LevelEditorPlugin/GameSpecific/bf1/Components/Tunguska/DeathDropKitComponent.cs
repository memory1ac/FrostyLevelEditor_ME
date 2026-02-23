
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeathDropKitComponentData))]
public class DeathDropKitComponent : GameComponent, IEntityData<FrostySdk.Ebx.DeathDropKitComponentData>
{
    public new FrostySdk.Ebx.DeathDropKitComponentData Data => data as FrostySdk.Ebx.DeathDropKitComponentData;
    public override string DisplayName => "DeathDropKitComponent";

    public DeathDropKitComponent(FrostySdk.Ebx.DeathDropKitComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

