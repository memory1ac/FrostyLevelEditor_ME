namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIAutoTestWidgetData))]
public class UIAutoTestWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIAutoTestWidgetData>
{
    public new FrostySdk.Ebx.UIAutoTestWidgetData Data => data as FrostySdk.Ebx.UIAutoTestWidgetData;
    public override string DisplayName => "UIAutoTestWidget";

    public UIAutoTestWidget(FrostySdk.Ebx.UIAutoTestWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

