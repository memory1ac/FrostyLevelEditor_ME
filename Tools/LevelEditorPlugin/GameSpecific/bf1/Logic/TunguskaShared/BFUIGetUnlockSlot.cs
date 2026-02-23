namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetUnlockSlotData))]
public class BFUIGetUnlockSlot : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetUnlockSlotData>
{
    public new FrostySdk.Ebx.BFUIGetUnlockSlotData Data => data as FrostySdk.Ebx.BFUIGetUnlockSlotData;
    public override string DisplayName => "BFUIGetUnlockSlot";

    public BFUIGetUnlockSlot(FrostySdk.Ebx.BFUIGetUnlockSlotData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

