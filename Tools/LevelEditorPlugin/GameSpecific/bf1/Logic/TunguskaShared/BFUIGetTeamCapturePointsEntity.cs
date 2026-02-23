namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetTeamCapturePointsEntityData))]
public class BFUIGetTeamCapturePointsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetTeamCapturePointsEntityData>
{
    public new FrostySdk.Ebx.BFUIGetTeamCapturePointsEntityData Data => data as FrostySdk.Ebx.BFUIGetTeamCapturePointsEntityData;
    public override string DisplayName => "BFUIGetTeamCapturePoints";

    public BFUIGetTeamCapturePointsEntity(FrostySdk.Ebx.BFUIGetTeamCapturePointsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

