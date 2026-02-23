namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockEntityData))]
public class UnlockEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockEntityData>
{
    public new FrostySdk.Ebx.UnlockEntityData Data => data as FrostySdk.Ebx.UnlockEntityData;
    public override string DisplayName => "Unlock";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UnlockEntity(FrostySdk.Ebx.UnlockEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

