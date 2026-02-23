namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMedalTrackerEntityData))]
public class UIMedalTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMedalTrackerEntityData>
{
    public new FrostySdk.Ebx.UIMedalTrackerEntityData Data => data as FrostySdk.Ebx.UIMedalTrackerEntityData;
    public override string DisplayName => "UIMedalTracker";

    public UIMedalTrackerEntity(FrostySdk.Ebx.UIMedalTrackerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

