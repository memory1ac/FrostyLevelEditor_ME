namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIScoringWidgetData))]
public class UIScoringWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIScoringWidgetData>
{
    public new FrostySdk.Ebx.UIScoringWidgetData Data => data as FrostySdk.Ebx.UIScoringWidgetData;
    public override string DisplayName => "UIScoringWidget";

    public UIScoringWidget(FrostySdk.Ebx.UIScoringWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

