namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EventRepeaterEntityData))]
public class EventRepeaterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EventRepeaterEntityData>
{
    public new FrostySdk.Ebx.EventRepeaterEntityData Data => data as FrostySdk.Ebx.EventRepeaterEntityData;
    public override string DisplayName => "EventRepeater";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public EventRepeaterEntity(FrostySdk.Ebx.EventRepeaterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

