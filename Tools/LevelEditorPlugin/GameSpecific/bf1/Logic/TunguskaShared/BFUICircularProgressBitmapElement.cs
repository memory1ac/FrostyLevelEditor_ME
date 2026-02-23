namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICircularProgressBitmapElementData))]
public class BFUICircularProgressBitmapElement : BFUIElementBitmapEntity, IEntityData<FrostySdk.Ebx.BFUICircularProgressBitmapElementData>
{
    public new FrostySdk.Ebx.BFUICircularProgressBitmapElementData Data => data as FrostySdk.Ebx.BFUICircularProgressBitmapElementData;
    public override string DisplayName => "BFUICircularProgressBitmapElement";

    public BFUICircularProgressBitmapElement(FrostySdk.Ebx.BFUICircularProgressBitmapElementData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

