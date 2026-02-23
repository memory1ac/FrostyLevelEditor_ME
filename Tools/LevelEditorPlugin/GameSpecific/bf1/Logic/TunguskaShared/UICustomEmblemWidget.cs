namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICustomEmblemWidgetData))]
public class UICustomEmblemWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICustomEmblemWidgetData>
{
    public new FrostySdk.Ebx.UICustomEmblemWidgetData Data => data as FrostySdk.Ebx.UICustomEmblemWidgetData;
    public override string DisplayName => "UICustomEmblemWidget";

    public UICustomEmblemWidget(FrostySdk.Ebx.UICustomEmblemWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

