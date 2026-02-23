
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierEmoteComponentData))]
public class SoldierEmoteComponent : GameComponent, IEntityData<FrostySdk.Ebx.SoldierEmoteComponentData>
{
    public new FrostySdk.Ebx.SoldierEmoteComponentData Data => data as FrostySdk.Ebx.SoldierEmoteComponentData;
    public override string DisplayName => "SoldierEmoteComponent";

    public SoldierEmoteComponent(FrostySdk.Ebx.SoldierEmoteComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

