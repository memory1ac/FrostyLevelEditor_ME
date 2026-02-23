namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementBlurEntityData))]
public class BFUIElementBlurEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementBlurEntityData>
{
    public new FrostySdk.Ebx.BFUIElementBlurEntityData Data => data as FrostySdk.Ebx.BFUIElementBlurEntityData;
    public override string DisplayName => "BFUIElementBlur";

    public BFUIElementBlurEntity(FrostySdk.Ebx.BFUIElementBlurEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

