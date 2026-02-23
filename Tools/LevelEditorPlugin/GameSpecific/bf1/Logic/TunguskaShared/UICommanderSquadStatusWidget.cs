namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderSquadStatusWidgetData))]
public class UICommanderSquadStatusWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICommanderSquadStatusWidgetData>
{
    public new FrostySdk.Ebx.UICommanderSquadStatusWidgetData Data => data as FrostySdk.Ebx.UICommanderSquadStatusWidgetData;
    public override string DisplayName => "UICommanderSquadStatusWidget";

    public UICommanderSquadStatusWidget(FrostySdk.Ebx.UICommanderSquadStatusWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

