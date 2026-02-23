namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PurchaseUnlockEntityData))]
public class PurchaseUnlockEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PurchaseUnlockEntityData>
{
    public new FrostySdk.Ebx.PurchaseUnlockEntityData Data => data as FrostySdk.Ebx.PurchaseUnlockEntityData;
    public override string DisplayName => "PurchaseUnlock";

    public PurchaseUnlockEntity(FrostySdk.Ebx.PurchaseUnlockEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

