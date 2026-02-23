namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIDynamicVehicleInformationWidgetReferenceEntityData))]
public class BFUIDynamicVehicleInformationWidgetReferenceEntity : WidgetReferenceEntity, IEntityData<FrostySdk.Ebx.BFUIDynamicVehicleInformationWidgetReferenceEntityData>
{
    public new FrostySdk.Ebx.BFUIDynamicVehicleInformationWidgetReferenceEntityData Data => data as FrostySdk.Ebx.BFUIDynamicVehicleInformationWidgetReferenceEntityData;

    public BFUIDynamicVehicleInformationWidgetReferenceEntity(FrostySdk.Ebx.BFUIDynamicVehicleInformationWidgetReferenceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

