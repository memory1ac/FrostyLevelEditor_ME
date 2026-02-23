namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINavigationEntityData))]
public class UINavigationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UINavigationEntityData>
{
    public new FrostySdk.Ebx.UINavigationEntityData Data => data as FrostySdk.Ebx.UINavigationEntityData;
    public override string DisplayName => "UINavigation";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UINavigationEntity(FrostySdk.Ebx.UINavigationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

