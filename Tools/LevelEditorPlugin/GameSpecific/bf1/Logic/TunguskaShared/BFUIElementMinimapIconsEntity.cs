namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementMinimapIconsEntityData))]
public class BFUIElementMinimapIconsEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementMinimapIconsEntityData>
{
    public new FrostySdk.Ebx.BFUIElementMinimapIconsEntityData Data => data as FrostySdk.Ebx.BFUIElementMinimapIconsEntityData;
    public override string DisplayName => "BFUIElementMinimapIcons";

    public BFUIElementMinimapIconsEntity(FrostySdk.Ebx.BFUIElementMinimapIconsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

