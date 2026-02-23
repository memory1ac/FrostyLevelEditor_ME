namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementQuadBitmapEntityData))]
public class BFUIElementQuadBitmapEntity : BFUIElementBitmapEntity, IEntityData<FrostySdk.Ebx.BFUIElementQuadBitmapEntityData>
{
    public new FrostySdk.Ebx.BFUIElementQuadBitmapEntityData Data => data as FrostySdk.Ebx.BFUIElementQuadBitmapEntityData;
    public override string DisplayName => "BFUIElementQuadBitmap";

    public BFUIElementQuadBitmapEntity(FrostySdk.Ebx.BFUIElementQuadBitmapEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

