namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockPurchaseInfoEntityData))]
public class UnlockPurchaseInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockPurchaseInfoEntityData>
{
    public new FrostySdk.Ebx.UnlockPurchaseInfoEntityData Data => data as FrostySdk.Ebx.UnlockPurchaseInfoEntityData;
    public override string DisplayName => "UnlockPurchaseInfo";

    public UnlockPurchaseInfoEntity(FrostySdk.Ebx.UnlockPurchaseInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

