namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIVehicleSeatingDataProviderEntityData))]
public class UIVehicleSeatingDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIVehicleSeatingDataProviderEntityData>
{
    public new FrostySdk.Ebx.UIVehicleSeatingDataProviderEntityData Data => data as FrostySdk.Ebx.UIVehicleSeatingDataProviderEntityData;
    public override string DisplayName => "UIVehicleSeatingDataProvider";

    public UIVehicleSeatingDataProviderEntity(FrostySdk.Ebx.UIVehicleSeatingDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

