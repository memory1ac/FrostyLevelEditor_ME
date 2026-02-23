namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TwinkleTextureUIElementEntityData))]
public class TwinkleTextureUIElementEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.TwinkleTextureUIElementEntityData>
{
    public new FrostySdk.Ebx.TwinkleTextureUIElementEntityData Data => data as FrostySdk.Ebx.TwinkleTextureUIElementEntityData;
    public override string DisplayName => "TwinkleTextureUIElement";

    public TwinkleTextureUIElementEntity(FrostySdk.Ebx.TwinkleTextureUIElementEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

