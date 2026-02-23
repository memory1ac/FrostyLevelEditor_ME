namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleDriverEntityData))]
public class SimpleDriverEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SimpleDriverEntityData>
{
    public new FrostySdk.Ebx.SimpleDriverEntityData Data => data as FrostySdk.Ebx.SimpleDriverEntityData;
    public override string DisplayName => "SimpleDriver";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SimpleDriverEntity(FrostySdk.Ebx.SimpleDriverEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

