namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutWidgetData))]
public class BFUILayoutWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUILayoutWidgetData>
{
    public new FrostySdk.Ebx.BFUILayoutWidgetData Data => data as FrostySdk.Ebx.BFUILayoutWidgetData;
    public override string DisplayName => "BFUILayoutWidget";

    public BFUILayoutWidget(FrostySdk.Ebx.BFUILayoutWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

