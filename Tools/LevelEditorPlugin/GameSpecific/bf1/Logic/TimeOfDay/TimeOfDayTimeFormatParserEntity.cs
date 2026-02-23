namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayTimeFormatParserEntityData))]
public class TimeOfDayTimeFormatParserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayTimeFormatParserEntityData>
{
    public new FrostySdk.Ebx.TimeOfDayTimeFormatParserEntityData Data => data as FrostySdk.Ebx.TimeOfDayTimeFormatParserEntityData;
    public override string DisplayName => "TimeOfDayTimeFormatParser";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TimeOfDayTimeFormatParserEntity(FrostySdk.Ebx.TimeOfDayTimeFormatParserEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

