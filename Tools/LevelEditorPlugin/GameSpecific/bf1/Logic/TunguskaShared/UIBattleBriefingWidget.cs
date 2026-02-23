namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBattleBriefingWidgetData))]
public class UIBattleBriefingWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBattleBriefingWidgetData>
{
    public new FrostySdk.Ebx.UIBattleBriefingWidgetData Data => data as FrostySdk.Ebx.UIBattleBriefingWidgetData;
    public override string DisplayName => "UIBattleBriefingWidget";

    public UIBattleBriefingWidget(FrostySdk.Ebx.UIBattleBriefingWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

