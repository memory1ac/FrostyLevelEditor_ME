namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBadConnectionWidgetData))]
public class UIBadConnectionWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIBadConnectionWidgetData>
{
    public new FrostySdk.Ebx.UIBadConnectionWidgetData Data => data as FrostySdk.Ebx.UIBadConnectionWidgetData;
    public override string DisplayName => "UIBadConnectionWidget";

    public UIBadConnectionWidget(FrostySdk.Ebx.UIBadConnectionWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

