namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ProjectileTrajectoryEntityData))]
public class ProjectileTrajectoryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ProjectileTrajectoryEntityData>
{
    public new FrostySdk.Ebx.ProjectileTrajectoryEntityData Data => data as FrostySdk.Ebx.ProjectileTrajectoryEntityData;
    public override string DisplayName => "ProjectileTrajectory";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ProjectileTrajectoryEntity(FrostySdk.Ebx.ProjectileTrajectoryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

