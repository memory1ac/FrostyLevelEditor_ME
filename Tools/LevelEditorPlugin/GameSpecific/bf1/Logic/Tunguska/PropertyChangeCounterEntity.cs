namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PropertyChangeCounterEntityData))]
public class PropertyChangeCounterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PropertyChangeCounterEntityData>
{
    public new FrostySdk.Ebx.PropertyChangeCounterEntityData Data => data as FrostySdk.Ebx.PropertyChangeCounterEntityData;
    public override string DisplayName => "PropertyChangeCounter";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PropertyChangeCounterEntity(FrostySdk.Ebx.PropertyChangeCounterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

