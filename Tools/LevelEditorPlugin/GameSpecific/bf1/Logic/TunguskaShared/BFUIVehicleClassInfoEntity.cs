namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIVehicleClassInfoEntityData))]
public class BFUIVehicleClassInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIVehicleClassInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIVehicleClassInfoEntityData Data => data as FrostySdk.Ebx.BFUIVehicleClassInfoEntityData;
    public override string DisplayName => "BFUIVehicleClassInfo";

    public BFUIVehicleClassInfoEntity(FrostySdk.Ebx.BFUIVehicleClassInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

