namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILevelInfoEntityData))]
public class UILevelInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILevelInfoEntityData>
{
    public new FrostySdk.Ebx.UILevelInfoEntityData Data => data as FrostySdk.Ebx.UILevelInfoEntityData;
    public override string DisplayName => "UILevelInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILevelInfoEntity(FrostySdk.Ebx.UILevelInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

