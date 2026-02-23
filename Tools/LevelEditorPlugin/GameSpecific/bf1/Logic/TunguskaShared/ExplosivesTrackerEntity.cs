namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ExplosivesTrackerEntityData))]
public class ExplosivesTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ExplosivesTrackerEntityData>
{
    public new FrostySdk.Ebx.ExplosivesTrackerEntityData Data => data as FrostySdk.Ebx.ExplosivesTrackerEntityData;
    public override string DisplayName => "ExplosivesTracker";

    public ExplosivesTrackerEntity(FrostySdk.Ebx.ExplosivesTrackerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

