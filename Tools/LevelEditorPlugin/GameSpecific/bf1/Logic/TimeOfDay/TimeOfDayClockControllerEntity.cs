namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayClockControllerEntityData))]
public class TimeOfDayClockControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayClockControllerEntityData>
{
    public new FrostySdk.Ebx.TimeOfDayClockControllerEntityData Data => data as FrostySdk.Ebx.TimeOfDayClockControllerEntityData;
    public override string DisplayName => "TimeOfDayClockController";

    public TimeOfDayClockControllerEntity(FrostySdk.Ebx.TimeOfDayClockControllerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

