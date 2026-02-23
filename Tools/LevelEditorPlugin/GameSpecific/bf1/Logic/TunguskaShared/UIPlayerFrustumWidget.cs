namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPlayerFrustumWidgetData))]
public class UIPlayerFrustumWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIPlayerFrustumWidgetData>
{
    public new FrostySdk.Ebx.UIPlayerFrustumWidgetData Data => data as FrostySdk.Ebx.UIPlayerFrustumWidgetData;
    public override string DisplayName => "UIPlayerFrustumWidget";

    public UIPlayerFrustumWidget(FrostySdk.Ebx.UIPlayerFrustumWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

