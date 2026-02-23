namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementMinimapCaptureAreaEntityData))]
public class BFUIElementMinimapCaptureAreaEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementMinimapCaptureAreaEntityData>
{
    public new FrostySdk.Ebx.BFUIElementMinimapCaptureAreaEntityData Data => data as FrostySdk.Ebx.BFUIElementMinimapCaptureAreaEntityData;
    public override string DisplayName => "BFUIElementMinimapCaptureArea";

    public BFUIElementMinimapCaptureAreaEntity(FrostySdk.Ebx.BFUIElementMinimapCaptureAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

