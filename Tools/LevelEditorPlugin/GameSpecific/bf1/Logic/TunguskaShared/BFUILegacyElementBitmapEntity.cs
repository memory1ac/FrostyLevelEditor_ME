namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementBitmapEntityData))]
public class BFUILegacyElementBitmapEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementBitmapEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementBitmapEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementBitmapEntityData;
    public override string DisplayName => "BFUILegacyElementBitmap";

    public BFUILegacyElementBitmapEntity(FrostySdk.Ebx.BFUILegacyElementBitmapEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

