namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICompassWidgetData))]
public class UICompassWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICompassWidgetData>
{
    public new FrostySdk.Ebx.UICompassWidgetData Data => data as FrostySdk.Ebx.UICompassWidgetData;
    public override string DisplayName => "UICompassWidget";

    public UICompassWidget(FrostySdk.Ebx.UICompassWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

