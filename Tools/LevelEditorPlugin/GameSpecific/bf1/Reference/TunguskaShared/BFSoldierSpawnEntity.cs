namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSoldierSpawnEntityData))]
public class BFSoldierSpawnEntity : CharacterSpawnReferenceObject, IEntityData<FrostySdk.Ebx.BFSoldierSpawnEntityData>
{
    public new FrostySdk.Ebx.BFSoldierSpawnEntityData Data => data as FrostySdk.Ebx.BFSoldierSpawnEntityData;

    public BFSoldierSpawnEntity(FrostySdk.Ebx.BFSoldierSpawnEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

