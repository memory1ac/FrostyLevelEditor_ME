namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIEquipmentSwitchWidgetData))]
public class UIEquipmentSwitchWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIEquipmentSwitchWidgetData>
{
    public new FrostySdk.Ebx.UIEquipmentSwitchWidgetData Data => data as FrostySdk.Ebx.UIEquipmentSwitchWidgetData;
    public override string DisplayName => "UIEquipmentSwitchWidget";

    public UIEquipmentSwitchWidget(FrostySdk.Ebx.UIEquipmentSwitchWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

