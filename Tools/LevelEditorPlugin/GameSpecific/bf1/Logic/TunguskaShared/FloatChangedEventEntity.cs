namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatChangedEventEntityData))]
public class FloatChangedEventEntity : PropertyChangedEventEntityBase, IEntityData<FrostySdk.Ebx.FloatChangedEventEntityData>
{
    public new FrostySdk.Ebx.FloatChangedEventEntityData Data => data as FrostySdk.Ebx.FloatChangedEventEntityData;
    public override string DisplayName => "FloatChangedEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatChangedEventEntity(FrostySdk.Ebx.FloatChangedEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

