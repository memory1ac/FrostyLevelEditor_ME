namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPartyWidgetData))]
public class UIPartyWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIPartyWidgetData>
{
    public new FrostySdk.Ebx.UIPartyWidgetData Data => data as FrostySdk.Ebx.UIPartyWidgetData;
    public override string DisplayName => "UIPartyWidget";

    public UIPartyWidget(FrostySdk.Ebx.UIPartyWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

