namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TwinkleToJsEventEntityData))]
public class TwinkleToJsEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TwinkleToJsEventEntityData>
{
    public new FrostySdk.Ebx.TwinkleToJsEventEntityData Data => data as FrostySdk.Ebx.TwinkleToJsEventEntityData;
    public override string DisplayName => "TwinkleToJsEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TwinkleToJsEventEntity(FrostySdk.Ebx.TwinkleToJsEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

