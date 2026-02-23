namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayBlendEntityData))]
public class TimeOfDayBlendEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayBlendEntityData>
{
    public new FrostySdk.Ebx.TimeOfDayBlendEntityData Data => data as FrostySdk.Ebx.TimeOfDayBlendEntityData;
    public override string DisplayName => "TimeOfDayBlend";

    public TimeOfDayBlendEntity(FrostySdk.Ebx.TimeOfDayBlendEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

