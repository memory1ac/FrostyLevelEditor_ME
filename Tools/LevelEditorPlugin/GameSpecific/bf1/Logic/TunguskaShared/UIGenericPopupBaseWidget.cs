namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIGenericPopupBaseWidgetData))]
public class UIGenericPopupBaseWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIGenericPopupBaseWidgetData>
{
    public new FrostySdk.Ebx.UIGenericPopupBaseWidgetData Data => data as FrostySdk.Ebx.UIGenericPopupBaseWidgetData;
    public override string DisplayName => "UIGenericPopupBaseWidget";

    public UIGenericPopupBaseWidget(FrostySdk.Ebx.UIGenericPopupBaseWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

