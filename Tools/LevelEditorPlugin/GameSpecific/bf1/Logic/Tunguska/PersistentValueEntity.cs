namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PersistentValueEntityData))]
public class PersistentValueEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PersistentValueEntityData>
{
    public new FrostySdk.Ebx.PersistentValueEntityData Data => data as FrostySdk.Ebx.PersistentValueEntityData;
    public override string DisplayName => "PersistentValue";

    public PersistentValueEntity(FrostySdk.Ebx.PersistentValueEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

