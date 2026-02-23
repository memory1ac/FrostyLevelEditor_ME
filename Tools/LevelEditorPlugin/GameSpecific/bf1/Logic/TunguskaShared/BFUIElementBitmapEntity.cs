namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementBitmapEntityData))]
public class BFUIElementBitmapEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementBitmapEntityData>
{
    public new FrostySdk.Ebx.BFUIElementBitmapEntityData Data => data as FrostySdk.Ebx.BFUIElementBitmapEntityData;
    public override string DisplayName => "BFUIElementBitmap";

    public BFUIElementBitmapEntity(FrostySdk.Ebx.BFUIElementBitmapEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

