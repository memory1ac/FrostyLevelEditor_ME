namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIListCellWidgetData))]
public class BFUIListCellWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUIListCellWidgetData>
{
    public new FrostySdk.Ebx.BFUIListCellWidgetData Data => data as FrostySdk.Ebx.BFUIListCellWidgetData;
    public override string DisplayName => "BFUIListCellWidget";

    public BFUIListCellWidget(FrostySdk.Ebx.BFUIListCellWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

