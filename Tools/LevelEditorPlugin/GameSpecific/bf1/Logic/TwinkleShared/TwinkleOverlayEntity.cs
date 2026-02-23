namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TwinkleOverlayEntityData))]
public class TwinkleOverlayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TwinkleOverlayEntityData>
{
    public new FrostySdk.Ebx.TwinkleOverlayEntityData Data => data as FrostySdk.Ebx.TwinkleOverlayEntityData;
    public override string DisplayName => "TwinkleOverlay";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TwinkleOverlayEntity(FrostySdk.Ebx.TwinkleOverlayEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

