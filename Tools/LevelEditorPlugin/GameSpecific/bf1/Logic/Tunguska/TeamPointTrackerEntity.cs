namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TeamPointTrackerEntityData))]
public class TeamPointTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TeamPointTrackerEntityData>
{
    public new FrostySdk.Ebx.TeamPointTrackerEntityData Data => data as FrostySdk.Ebx.TeamPointTrackerEntityData;
    public override string DisplayName => "TeamPointTracker";

    public TeamPointTrackerEntity(FrostySdk.Ebx.TeamPointTrackerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

