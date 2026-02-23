namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISplinePathBuilderEntityData))]
public class UISplinePathBuilderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISplinePathBuilderEntityData>
{
    public new FrostySdk.Ebx.UISplinePathBuilderEntityData Data => data as FrostySdk.Ebx.UISplinePathBuilderEntityData;
    public override string DisplayName => "UISplinePathBuilder";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISplinePathBuilderEntity(FrostySdk.Ebx.UISplinePathBuilderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

