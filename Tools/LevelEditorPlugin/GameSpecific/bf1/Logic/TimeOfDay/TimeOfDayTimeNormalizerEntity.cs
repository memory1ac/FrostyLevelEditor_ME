namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayTimeNormalizerEntityData))]
public class TimeOfDayTimeNormalizerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayTimeNormalizerEntityData>
{
    public new FrostySdk.Ebx.TimeOfDayTimeNormalizerEntityData Data => data as FrostySdk.Ebx.TimeOfDayTimeNormalizerEntityData;
    public override string DisplayName => "TimeOfDayTimeNormalizer";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TimeOfDayTimeNormalizerEntity(FrostySdk.Ebx.TimeOfDayTimeNormalizerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

