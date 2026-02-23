namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIListWidgetData))]
public class BFUIListWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUIListWidgetData>
{
    public new FrostySdk.Ebx.BFUIListWidgetData Data => data as FrostySdk.Ebx.BFUIListWidgetData;
    public override string DisplayName => "BFUIListWidget";

    public BFUIListWidget(FrostySdk.Ebx.BFUIListWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

