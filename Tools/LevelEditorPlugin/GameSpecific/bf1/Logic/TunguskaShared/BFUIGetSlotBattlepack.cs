namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetSlotBattlepackData))]
public class BFUIGetSlotBattlepack : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetSlotBattlepackData>
{
    public new FrostySdk.Ebx.BFUIGetSlotBattlepackData Data => data as FrostySdk.Ebx.BFUIGetSlotBattlepackData;
    public override string DisplayName => "BFUIGetSlotBattlepack";

    public BFUIGetSlotBattlepack(FrostySdk.Ebx.BFUIGetSlotBattlepackData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

