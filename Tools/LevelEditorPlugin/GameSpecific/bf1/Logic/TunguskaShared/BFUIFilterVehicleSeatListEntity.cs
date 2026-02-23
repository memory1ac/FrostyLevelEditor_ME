namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIFilterVehicleSeatListEntityData))]
public class BFUIFilterVehicleSeatListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIFilterVehicleSeatListEntityData>
{
    public new FrostySdk.Ebx.BFUIFilterVehicleSeatListEntityData Data => data as FrostySdk.Ebx.BFUIFilterVehicleSeatListEntityData;
    public override string DisplayName => "BFUIFilterVehicleSeatList";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIFilterVehicleSeatListEntity(FrostySdk.Ebx.BFUIFilterVehicleSeatListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

