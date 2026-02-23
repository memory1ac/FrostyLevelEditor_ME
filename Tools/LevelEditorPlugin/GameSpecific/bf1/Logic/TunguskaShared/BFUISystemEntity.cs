namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISystemEntityData))]
public class BFUISystemEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISystemEntityData>
{
    public new FrostySdk.Ebx.BFUISystemEntityData Data => data as FrostySdk.Ebx.BFUISystemEntityData;
    public override string DisplayName => "BFUISystem";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUISystemEntity(FrostySdk.Ebx.BFUISystemEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

