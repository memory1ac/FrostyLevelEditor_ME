namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMPLoadingWidgetData))]
public class UIMPLoadingWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMPLoadingWidgetData>
{
    public new FrostySdk.Ebx.UIMPLoadingWidgetData Data => data as FrostySdk.Ebx.UIMPLoadingWidgetData;
    public override string DisplayName => "UIMPLoadingWidget";

    public UIMPLoadingWidget(FrostySdk.Ebx.UIMPLoadingWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

