namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINetGraphWidgetData))]
public class UINetGraphWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UINetGraphWidgetData>
{
    public new FrostySdk.Ebx.UINetGraphWidgetData Data => data as FrostySdk.Ebx.UINetGraphWidgetData;
    public override string DisplayName => "UINetGraphWidget";

    public UINetGraphWidget(FrostySdk.Ebx.UINetGraphWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

