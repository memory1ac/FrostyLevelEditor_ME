namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISplineVertexBuilderEntityData))]
public class UISplineVertexBuilderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISplineVertexBuilderEntityData>
{
    public new FrostySdk.Ebx.UISplineVertexBuilderEntityData Data => data as FrostySdk.Ebx.UISplineVertexBuilderEntityData;
    public override string DisplayName => "UISplineVertexBuilder";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISplineVertexBuilderEntity(FrostySdk.Ebx.UISplineVertexBuilderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

