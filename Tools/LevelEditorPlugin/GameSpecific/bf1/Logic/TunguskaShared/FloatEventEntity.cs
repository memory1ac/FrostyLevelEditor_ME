namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatEventEntityData))]
public class FloatEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatEventEntityData>
{
    public new FrostySdk.Ebx.FloatEventEntityData Data => data as FrostySdk.Ebx.FloatEventEntityData;
    public override string DisplayName => "FloatEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatEventEntity(FrostySdk.Ebx.FloatEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

