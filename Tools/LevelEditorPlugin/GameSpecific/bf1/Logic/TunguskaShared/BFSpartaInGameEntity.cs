namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpartaInGameEntityData))]
public class BFSpartaInGameEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpartaInGameEntityData>
{
    public new FrostySdk.Ebx.BFSpartaInGameEntityData Data => data as FrostySdk.Ebx.BFSpartaInGameEntityData;
    public override string DisplayName => "BFSpartaInGame";

    public BFSpartaInGameEntity(FrostySdk.Ebx.BFSpartaInGameEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

