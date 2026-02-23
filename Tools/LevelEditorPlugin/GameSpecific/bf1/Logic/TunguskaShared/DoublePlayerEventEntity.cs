namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DoublePlayerEventEntityData))]
public class DoublePlayerEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DoublePlayerEventEntityData>
{
    public new FrostySdk.Ebx.DoublePlayerEventEntityData Data => data as FrostySdk.Ebx.DoublePlayerEventEntityData;
    public override string DisplayName => "DoublePlayerEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DoublePlayerEventEntity(FrostySdk.Ebx.DoublePlayerEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

