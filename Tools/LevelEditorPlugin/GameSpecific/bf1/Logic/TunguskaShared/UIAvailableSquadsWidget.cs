namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIAvailableSquadsWidgetData))]
public class UIAvailableSquadsWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIAvailableSquadsWidgetData>
{
    public new FrostySdk.Ebx.UIAvailableSquadsWidgetData Data => data as FrostySdk.Ebx.UIAvailableSquadsWidgetData;
    public override string DisplayName => "UIAvailableSquadsWidget";

    public UIAvailableSquadsWidget(FrostySdk.Ebx.UIAvailableSquadsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

