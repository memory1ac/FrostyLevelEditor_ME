namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISectorsWidgetData))]
public class UISectorsWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UISectorsWidgetData>
{
    public new FrostySdk.Ebx.UISectorsWidgetData Data => data as FrostySdk.Ebx.UISectorsWidgetData;
    public override string DisplayName => "UISectorsWidget";

    public UISectorsWidget(FrostySdk.Ebx.UISectorsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

