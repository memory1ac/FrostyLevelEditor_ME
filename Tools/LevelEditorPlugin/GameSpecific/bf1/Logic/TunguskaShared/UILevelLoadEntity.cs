namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILevelLoadEntityData))]
public class UILevelLoadEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILevelLoadEntityData>
{
    public new FrostySdk.Ebx.UILevelLoadEntityData Data => data as FrostySdk.Ebx.UILevelLoadEntityData;
    public override string DisplayName => "UILevelLoad";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILevelLoadEntity(FrostySdk.Ebx.UILevelLoadEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

