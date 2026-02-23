namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIOrderLineWidgetData))]
public class UIOrderLineWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIOrderLineWidgetData>
{
    public new FrostySdk.Ebx.UIOrderLineWidgetData Data => data as FrostySdk.Ebx.UIOrderLineWidgetData;
    public override string DisplayName => "UIOrderLineWidget";

    public UIOrderLineWidget(FrostySdk.Ebx.UIOrderLineWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

