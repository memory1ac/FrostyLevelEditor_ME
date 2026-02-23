namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMissionTrackerEntityData))]
public class UIMissionTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMissionTrackerEntityData>
{
    public new FrostySdk.Ebx.UIMissionTrackerEntityData Data => data as FrostySdk.Ebx.UIMissionTrackerEntityData;
    public override string DisplayName => "UIMissionTracker";

    public UIMissionTrackerEntity(FrostySdk.Ebx.UIMissionTrackerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

