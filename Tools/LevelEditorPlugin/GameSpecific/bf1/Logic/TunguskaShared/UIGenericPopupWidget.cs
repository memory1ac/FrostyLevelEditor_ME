namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIGenericPopupWidgetData))]
public class UIGenericPopupWidget : UIPopupWidget, IEntityData<FrostySdk.Ebx.UIGenericPopupWidgetData>
{
    public new FrostySdk.Ebx.UIGenericPopupWidgetData Data => data as FrostySdk.Ebx.UIGenericPopupWidgetData;
    public override string DisplayName => "UIGenericPopupWidget";

    public UIGenericPopupWidget(FrostySdk.Ebx.UIGenericPopupWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

