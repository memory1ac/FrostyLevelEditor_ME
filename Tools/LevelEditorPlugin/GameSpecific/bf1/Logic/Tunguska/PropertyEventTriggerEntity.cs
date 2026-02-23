namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PropertyEventTriggerEntityData))]
public class PropertyEventTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PropertyEventTriggerEntityData>
{
    public new FrostySdk.Ebx.PropertyEventTriggerEntityData Data => data as FrostySdk.Ebx.PropertyEventTriggerEntityData;
    public override string DisplayName => "PropertyEventTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PropertyEventTriggerEntity(FrostySdk.Ebx.PropertyEventTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

