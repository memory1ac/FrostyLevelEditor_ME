namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIUnlockInfoEntityData))]
public class BFUIUnlockInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIUnlockInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIUnlockInfoEntityData Data => data as FrostySdk.Ebx.BFUIUnlockInfoEntityData;
    public override string DisplayName => "BFUIUnlockInfo";

    public BFUIUnlockInfoEntity(FrostySdk.Ebx.BFUIUnlockInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

