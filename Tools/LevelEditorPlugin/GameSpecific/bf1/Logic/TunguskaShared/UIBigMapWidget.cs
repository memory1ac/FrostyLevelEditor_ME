namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBigMapWidgetData))]
public class UIBigMapWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBigMapWidgetData>
{
    public new FrostySdk.Ebx.UIBigMapWidgetData Data => data as FrostySdk.Ebx.UIBigMapWidgetData;
    public override string DisplayName => "UIBigMapWidget";

    public UIBigMapWidget(FrostySdk.Ebx.UIBigMapWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

