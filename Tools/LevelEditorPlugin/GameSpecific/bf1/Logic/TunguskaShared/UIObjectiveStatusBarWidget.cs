namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIObjectiveStatusBarWidgetData))]
public class UIObjectiveStatusBarWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIObjectiveStatusBarWidgetData>
{
    public new FrostySdk.Ebx.UIObjectiveStatusBarWidgetData Data => data as FrostySdk.Ebx.UIObjectiveStatusBarWidgetData;
    public override string DisplayName => "UIObjectiveStatusBarWidget";

    public UIObjectiveStatusBarWidget(FrostySdk.Ebx.UIObjectiveStatusBarWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

