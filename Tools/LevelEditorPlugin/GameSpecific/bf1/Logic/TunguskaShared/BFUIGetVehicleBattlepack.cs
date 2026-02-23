namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetVehicleBattlepackData))]
public class BFUIGetVehicleBattlepack : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetVehicleBattlepackData>
{
    public new FrostySdk.Ebx.BFUIGetVehicleBattlepackData Data => data as FrostySdk.Ebx.BFUIGetVehicleBattlepackData;
    public override string DisplayName => "BFUIGetVehicleBattlepack";

    public BFUIGetVehicleBattlepack(FrostySdk.Ebx.BFUIGetVehicleBattlepackData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

