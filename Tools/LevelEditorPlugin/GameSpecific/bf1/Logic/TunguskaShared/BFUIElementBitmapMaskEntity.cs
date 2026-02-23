namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementBitmapMaskEntityData))]
public class BFUIElementBitmapMaskEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementBitmapMaskEntityData>
{
    public new FrostySdk.Ebx.BFUIElementBitmapMaskEntityData Data => data as FrostySdk.Ebx.BFUIElementBitmapMaskEntityData;
    public override string DisplayName => "BFUIElementBitmapMask";

    public BFUIElementBitmapMaskEntity(FrostySdk.Ebx.BFUIElementBitmapMaskEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

