namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIFrontendEntityData))]
public class UIFrontendEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIFrontendEntityData>
{
    public new FrostySdk.Ebx.UIFrontendEntityData Data => data as FrostySdk.Ebx.UIFrontendEntityData;
    public override string DisplayName => "UIFrontend";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIFrontendEntity(FrostySdk.Ebx.UIFrontendEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

