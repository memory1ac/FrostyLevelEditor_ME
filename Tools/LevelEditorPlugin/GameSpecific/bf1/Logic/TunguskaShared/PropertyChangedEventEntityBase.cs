namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PropertyChangedEventEntityBaseData))]
public class PropertyChangedEventEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.PropertyChangedEventEntityBaseData>
{
    public new FrostySdk.Ebx.PropertyChangedEventEntityBaseData Data => data as FrostySdk.Ebx.PropertyChangedEventEntityBaseData;
    public override string DisplayName => "PropertyChangedEventEntityBase";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PropertyChangedEventEntityBase(FrostySdk.Ebx.PropertyChangedEventEntityBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

