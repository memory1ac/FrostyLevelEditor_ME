namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIDynamicWidgetRendererElementData))]
public class BFUIDynamicWidgetRendererElement : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIDynamicWidgetRendererElementData>
{
    public new FrostySdk.Ebx.BFUIDynamicWidgetRendererElementData Data => data as FrostySdk.Ebx.BFUIDynamicWidgetRendererElementData;
    public override string DisplayName => "BFUIDynamicWidgetRendererElement";

    public BFUIDynamicWidgetRendererElement(FrostySdk.Ebx.BFUIDynamicWidgetRendererElementData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

