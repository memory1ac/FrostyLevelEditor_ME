namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientUIVehicleSeatRotationEntityData))]
public class ClientUIVehicleSeatRotationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientUIVehicleSeatRotationEntityData>
{
    public new FrostySdk.Ebx.ClientUIVehicleSeatRotationEntityData Data => data as FrostySdk.Ebx.ClientUIVehicleSeatRotationEntityData;
    public override string DisplayName => "ClientUIVehicleSeatRotation";

    public ClientUIVehicleSeatRotationEntity(FrostySdk.Ebx.ClientUIVehicleSeatRotationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

