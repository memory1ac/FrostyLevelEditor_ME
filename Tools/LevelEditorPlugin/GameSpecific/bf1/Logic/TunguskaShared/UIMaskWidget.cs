namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMaskWidgetData))]
public class UIMaskWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMaskWidgetData>
{
    public new FrostySdk.Ebx.UIMaskWidgetData Data => data as FrostySdk.Ebx.UIMaskWidgetData;
    public override string DisplayName => "UIMaskWidget";

    public UIMaskWidget(FrostySdk.Ebx.UIMaskWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

