namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectator3pSoldierCameraInfoEntityData))]
public class BFSpectator3pSoldierCameraInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpectator3pSoldierCameraInfoEntityData>
{
    public new FrostySdk.Ebx.BFSpectator3pSoldierCameraInfoEntityData Data => data as FrostySdk.Ebx.BFSpectator3pSoldierCameraInfoEntityData;
    public override string DisplayName => "BFSpectator3pSoldierCameraInfo";

    public BFSpectator3pSoldierCameraInfoEntity(FrostySdk.Ebx.BFSpectator3pSoldierCameraInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

