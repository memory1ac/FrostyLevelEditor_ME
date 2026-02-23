namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectDataEntityData))]
public class ObjectDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ObjectDataEntityData>
{
    public new FrostySdk.Ebx.ObjectDataEntityData Data => data as FrostySdk.Ebx.ObjectDataEntityData;
    public override string DisplayName => "ObjectData";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ObjectDataEntity(FrostySdk.Ebx.ObjectDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

