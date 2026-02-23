namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICalibrationManagerEntityData))]
public class BFUICalibrationManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUICalibrationManagerEntityData>
{
    public new FrostySdk.Ebx.BFUICalibrationManagerEntityData Data => data as FrostySdk.Ebx.BFUICalibrationManagerEntityData;
    public override string DisplayName => "BFUICalibrationManager";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUICalibrationManagerEntity(FrostySdk.Ebx.BFUICalibrationManagerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

