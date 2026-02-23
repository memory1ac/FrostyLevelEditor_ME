namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TwinkleFromJsEventEntityData))]
public class TwinkleFromJsEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TwinkleFromJsEventEntityData>
{
    public new FrostySdk.Ebx.TwinkleFromJsEventEntityData Data => data as FrostySdk.Ebx.TwinkleFromJsEventEntityData;
    public override string DisplayName => "TwinkleFromJsEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TwinkleFromJsEventEntity(FrostySdk.Ebx.TwinkleFromJsEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

