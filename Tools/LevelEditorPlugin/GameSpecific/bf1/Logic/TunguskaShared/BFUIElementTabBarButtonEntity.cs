namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementTabBarButtonEntityData))]
public class BFUIElementTabBarButtonEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementTabBarButtonEntityData>
{
    public new FrostySdk.Ebx.BFUIElementTabBarButtonEntityData Data => data as FrostySdk.Ebx.BFUIElementTabBarButtonEntityData;
    public override string DisplayName => "BFUIElementTabBarButton";

    public BFUIElementTabBarButtonEntity(FrostySdk.Ebx.BFUIElementTabBarButtonEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

