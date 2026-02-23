namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BoolChangedEventEntityData))]
public class BoolChangedEventEntity : PropertyChangedEventEntityBase, IEntityData<FrostySdk.Ebx.BoolChangedEventEntityData>
{
    public new FrostySdk.Ebx.BoolChangedEventEntityData Data => data as FrostySdk.Ebx.BoolChangedEventEntityData;
    public override string DisplayName => "BoolChangedEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BoolChangedEventEntity(FrostySdk.Ebx.BoolChangedEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

