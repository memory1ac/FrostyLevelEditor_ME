namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerVehicleInfoEntityData))]
public class BFUIPlayerVehicleInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerVehicleInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerVehicleInfoEntityData Data => data as FrostySdk.Ebx.BFUIPlayerVehicleInfoEntityData;
    public override string DisplayName => "BFUIPlayerVehicleInfo";

    public BFUIPlayerVehicleInfoEntity(FrostySdk.Ebx.BFUIPlayerVehicleInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

