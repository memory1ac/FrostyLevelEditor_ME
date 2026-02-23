namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBuildInfoWidgetData))]
public class UIBuildInfoWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBuildInfoWidgetData>
{
    public new FrostySdk.Ebx.UIBuildInfoWidgetData Data => data as FrostySdk.Ebx.UIBuildInfoWidgetData;
    public override string DisplayName => "UIBuildInfoWidget";

    public UIBuildInfoWidget(FrostySdk.Ebx.UIBuildInfoWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

