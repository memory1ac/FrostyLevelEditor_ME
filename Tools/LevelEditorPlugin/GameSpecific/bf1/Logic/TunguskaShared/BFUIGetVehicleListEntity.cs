namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetVehicleListEntityData))]
public class BFUIGetVehicleListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetVehicleListEntityData>
{
    public new FrostySdk.Ebx.BFUIGetVehicleListEntityData Data => data as FrostySdk.Ebx.BFUIGetVehicleListEntityData;
    public override string DisplayName => "BFUIGetVehicleList";

    public BFUIGetVehicleListEntity(FrostySdk.Ebx.BFUIGetVehicleListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

