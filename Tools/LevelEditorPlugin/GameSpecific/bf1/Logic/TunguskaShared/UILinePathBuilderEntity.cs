namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILinePathBuilderEntityData))]
public class UILinePathBuilderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILinePathBuilderEntityData>
{
    public new FrostySdk.Ebx.UILinePathBuilderEntityData Data => data as FrostySdk.Ebx.UILinePathBuilderEntityData;
    public override string DisplayName => "UILinePathBuilder";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILinePathBuilderEntity(FrostySdk.Ebx.UILinePathBuilderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

