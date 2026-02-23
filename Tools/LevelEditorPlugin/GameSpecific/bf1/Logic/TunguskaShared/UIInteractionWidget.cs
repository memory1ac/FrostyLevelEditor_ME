namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIInteractionWidgetData))]
public class UIInteractionWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIInteractionWidgetData>
{
    public new FrostySdk.Ebx.UIInteractionWidgetData Data => data as FrostySdk.Ebx.UIInteractionWidgetData;
    public override string DisplayName => "UIInteractionWidget";

    public UIInteractionWidget(FrostySdk.Ebx.UIInteractionWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

