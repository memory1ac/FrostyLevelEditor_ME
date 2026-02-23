namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICombatAreaWidgetData))]
public class UICombatAreaWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UICombatAreaWidgetData>
{
    public new FrostySdk.Ebx.UICombatAreaWidgetData Data => data as FrostySdk.Ebx.UICombatAreaWidgetData;
    public override string DisplayName => "UICombatAreaWidget";

    public UICombatAreaWidget(FrostySdk.Ebx.UICombatAreaWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

