
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FlagComponentData))]
public class FlagComponent : GameComponent, IEntityData<FrostySdk.Ebx.FlagComponentData>
{
    public new FrostySdk.Ebx.FlagComponentData Data => data as FrostySdk.Ebx.FlagComponentData;
    public override string DisplayName => "FlagComponent";

    public FlagComponent(FrostySdk.Ebx.FlagComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

