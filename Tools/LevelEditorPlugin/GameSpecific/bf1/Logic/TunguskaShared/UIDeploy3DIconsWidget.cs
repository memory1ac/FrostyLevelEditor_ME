namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DIconsWidgetData))]
public class UIDeploy3DIconsWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DIconsWidgetData>
{
    public new FrostySdk.Ebx.UIDeploy3DIconsWidgetData Data => data as FrostySdk.Ebx.UIDeploy3DIconsWidgetData;
    public override string DisplayName => "UIDeploy3DIconsWidget";

    public UIDeploy3DIconsWidget(FrostySdk.Ebx.UIDeploy3DIconsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

