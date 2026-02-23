namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIWorldToScreenspaceWidgetData))]
public class UIWorldToScreenspaceWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIWorldToScreenspaceWidgetData>
{
    public new FrostySdk.Ebx.UIWorldToScreenspaceWidgetData Data => data as FrostySdk.Ebx.UIWorldToScreenspaceWidgetData;
    public override string DisplayName => "UIWorldToScreenspaceWidget";

    public UIWorldToScreenspaceWidget(FrostySdk.Ebx.UIWorldToScreenspaceWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

