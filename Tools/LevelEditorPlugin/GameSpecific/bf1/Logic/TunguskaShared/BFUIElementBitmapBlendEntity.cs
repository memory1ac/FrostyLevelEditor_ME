namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementBitmapBlendEntityData))]
public class BFUIElementBitmapBlendEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementBitmapBlendEntityData>
{
    public new FrostySdk.Ebx.BFUIElementBitmapBlendEntityData Data => data as FrostySdk.Ebx.BFUIElementBitmapBlendEntityData;
    public override string DisplayName => "BFUIElementBitmapBlend";

    public BFUIElementBitmapBlendEntity(FrostySdk.Ebx.BFUIElementBitmapBlendEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

