namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetPlayerListFromVehicleEntryListEntityData))]
public class BFUIGetPlayerListFromVehicleEntryListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetPlayerListFromVehicleEntryListEntityData>
{
    public new FrostySdk.Ebx.BFUIGetPlayerListFromVehicleEntryListEntityData Data => data as FrostySdk.Ebx.BFUIGetPlayerListFromVehicleEntryListEntityData;
    public override string DisplayName => "BFUIGetPlayerListFromVehicleEntryList";

    public BFUIGetPlayerListFromVehicleEntryListEntity(FrostySdk.Ebx.BFUIGetPlayerListFromVehicleEntryListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

