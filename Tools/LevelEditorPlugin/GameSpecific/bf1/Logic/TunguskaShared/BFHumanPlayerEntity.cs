namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFHumanPlayerEntityData))]
public class BFHumanPlayerEntity : HumanPlayerEntity, IEntityData<FrostySdk.Ebx.BFHumanPlayerEntityData>
{
    public new FrostySdk.Ebx.BFHumanPlayerEntityData Data => data as FrostySdk.Ebx.BFHumanPlayerEntityData;
    public override string DisplayName => "BFHumanPlayer";

    public BFHumanPlayerEntity(FrostySdk.Ebx.BFHumanPlayerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

