namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomizationVehicleEntityData))]
public class CustomizationVehicleEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CustomizationVehicleEntityData>
{
    public new FrostySdk.Ebx.CustomizationVehicleEntityData Data => data as FrostySdk.Ebx.CustomizationVehicleEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CustomizationVehicleEntity(FrostySdk.Ebx.CustomizationVehicleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

