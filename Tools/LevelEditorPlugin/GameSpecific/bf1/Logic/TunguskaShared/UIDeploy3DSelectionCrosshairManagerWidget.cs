namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DSelectionCrosshairManagerWidgetData))]
public class UIDeploy3DSelectionCrosshairManagerWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DSelectionCrosshairManagerWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DSelectionCrosshairManagerWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DSelectionCrosshairManagerWidgetData;
    public override string DisplayName => "UIDeploy3DSelectionCrosshairManagerWidget";

    public UIDeploy3DSelectionCrosshairManagerWidget(FrostySdk.Ebx.UIDeploy3DSelectionCrosshairManagerWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

