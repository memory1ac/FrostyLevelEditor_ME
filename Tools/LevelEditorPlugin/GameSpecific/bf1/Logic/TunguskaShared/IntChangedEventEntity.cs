namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.IntChangedEventEntityData))]
public class IntChangedEventEntity : PropertyChangedEventEntityBase, IEntityData<FrostySdk.Ebx.IntChangedEventEntityData>
{
    public new FrostySdk.Ebx.IntChangedEventEntityData Data => data as FrostySdk.Ebx.IntChangedEventEntityData;
    public override string DisplayName => "IntChangedEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public IntChangedEventEntity(FrostySdk.Ebx.IntChangedEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

