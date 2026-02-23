namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientUIVehicleSeatInputMappingEntityData))]
public class ClientUIVehicleSeatInputMappingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientUIVehicleSeatInputMappingEntityData>
{
    public new FrostySdk.Ebx.ClientUIVehicleSeatInputMappingEntityData Data => data as FrostySdk.Ebx.ClientUIVehicleSeatInputMappingEntityData;
    public override string DisplayName => "ClientUIVehicleSeatInputMapping";

    public ClientUIVehicleSeatInputMappingEntity(FrostySdk.Ebx.ClientUIVehicleSeatInputMappingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

