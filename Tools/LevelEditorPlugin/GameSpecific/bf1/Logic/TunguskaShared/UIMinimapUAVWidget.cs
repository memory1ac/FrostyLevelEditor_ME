namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMinimapUAVWidgetData))]
public class UIMinimapUAVWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMinimapUAVWidgetData>
{
    public new FrostySdk.Ebx.UIMinimapUAVWidgetData Data => data as FrostySdk.Ebx.UIMinimapUAVWidgetData;
    public override string DisplayName => "UIMinimapUAVWidget";

    public UIMinimapUAVWidget(FrostySdk.Ebx.UIMinimapUAVWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

