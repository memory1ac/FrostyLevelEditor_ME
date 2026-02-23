namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeferredTransformEntityData))]
public class DeferredTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeferredTransformEntityData>
{
    public new FrostySdk.Ebx.DeferredTransformEntityData Data => data as FrostySdk.Ebx.DeferredTransformEntityData;
    public override string DisplayName => "DeferredTransform";

    public DeferredTransformEntity(FrostySdk.Ebx.DeferredTransformEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

