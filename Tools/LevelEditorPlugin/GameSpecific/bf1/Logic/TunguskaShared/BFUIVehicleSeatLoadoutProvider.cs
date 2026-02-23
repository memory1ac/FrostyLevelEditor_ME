namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIVehicleSeatLoadoutProviderData))]
public class BFUIVehicleSeatLoadoutProvider : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIVehicleSeatLoadoutProviderData>
{
    public new FrostySdk.Ebx.BFUIVehicleSeatLoadoutProviderData Data => data as FrostySdk.Ebx.BFUIVehicleSeatLoadoutProviderData;
    public override string DisplayName => "BFUIVehicleSeatLoadoutProvider";

    public BFUIVehicleSeatLoadoutProvider(FrostySdk.Ebx.BFUIVehicleSeatLoadoutProviderData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

