namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FlagMeshHolderEntityData))]
public class FlagMeshHolderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FlagMeshHolderEntityData>
{
    public new FrostySdk.Ebx.FlagMeshHolderEntityData Data => data as FrostySdk.Ebx.FlagMeshHolderEntityData;
    public override string DisplayName => "FlagMeshHolder";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FlagMeshHolderEntity(FrostySdk.Ebx.FlagMeshHolderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

