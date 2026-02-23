namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpartaEndOfRoundEntityData))]
public class BFSpartaEndOfRoundEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpartaEndOfRoundEntityData>
{
    public new FrostySdk.Ebx.BFSpartaEndOfRoundEntityData Data => data as FrostySdk.Ebx.BFSpartaEndOfRoundEntityData;
    public override string DisplayName => "BFSpartaEndOfRound";

    public BFSpartaEndOfRoundEntity(FrostySdk.Ebx.BFSpartaEndOfRoundEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

