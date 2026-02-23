namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITeamSetupWidgetData))]
public class UITeamSetupWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UITeamSetupWidgetData>
{
    public new FrostySdk.Ebx.UITeamSetupWidgetData Data => data as FrostySdk.Ebx.UITeamSetupWidgetData;
    public override string DisplayName => "UITeamSetupWidget";

    public UITeamSetupWidget(FrostySdk.Ebx.UITeamSetupWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

