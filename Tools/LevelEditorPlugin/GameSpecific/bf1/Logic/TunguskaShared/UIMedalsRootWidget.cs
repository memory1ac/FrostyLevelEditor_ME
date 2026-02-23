namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMedalsRootWidgetData))]
public class UIMedalsRootWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIMedalsRootWidgetData>
{
    public new FrostySdk.Ebx.UIMedalsRootWidgetData Data => data as FrostySdk.Ebx.UIMedalsRootWidgetData;
    public override string DisplayName => "UIMedalsRootWidget";

    public UIMedalsRootWidget(FrostySdk.Ebx.UIMedalsRootWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

