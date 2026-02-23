namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementNavigationEntityData))]
public class BFUIElementNavigationEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementNavigationEntityData>
{
    public new FrostySdk.Ebx.BFUIElementNavigationEntityData Data => data as FrostySdk.Ebx.BFUIElementNavigationEntityData;
    public override string DisplayName => "BFUIElementNavigation";

    public BFUIElementNavigationEntity(FrostySdk.Ebx.BFUIElementNavigationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

