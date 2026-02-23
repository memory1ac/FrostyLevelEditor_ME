namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderAssetStatusWidgetData))]
public class UICommanderAssetStatusWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICommanderAssetStatusWidgetData>
{
    public new FrostySdk.Ebx.UICommanderAssetStatusWidgetData Data => data as FrostySdk.Ebx.UICommanderAssetStatusWidgetData;
    public override string DisplayName => "UICommanderAssetStatusWidget";

    public UICommanderAssetStatusWidget(FrostySdk.Ebx.UICommanderAssetStatusWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

