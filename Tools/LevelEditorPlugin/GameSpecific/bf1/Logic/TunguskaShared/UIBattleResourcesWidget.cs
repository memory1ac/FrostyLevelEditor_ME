namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBattleResourcesWidgetData))]
public class UIBattleResourcesWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBattleResourcesWidgetData>
{
    public new FrostySdk.Ebx.UIBattleResourcesWidgetData Data => data as FrostySdk.Ebx.UIBattleResourcesWidgetData;
    public override string DisplayName => "UIBattleResourcesWidget";

    public UIBattleResourcesWidget(FrostySdk.Ebx.UIBattleResourcesWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

