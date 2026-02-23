namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementColorizedBitmapEntityData))]
public class BFUIElementColorizedBitmapEntity : BFUIElementBitmapEntity, IEntityData<FrostySdk.Ebx.BFUIElementColorizedBitmapEntityData>
{
    public new FrostySdk.Ebx.BFUIElementColorizedBitmapEntityData Data => data as FrostySdk.Ebx.BFUIElementColorizedBitmapEntityData;
    public override string DisplayName => "BFUIElementColorizedBitmap";

    public BFUIElementColorizedBitmapEntity(FrostySdk.Ebx.BFUIElementColorizedBitmapEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

