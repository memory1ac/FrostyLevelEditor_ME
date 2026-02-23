namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RetargetTransformEntityData))]
public class RetargetTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RetargetTransformEntityData>
{
    public new FrostySdk.Ebx.RetargetTransformEntityData Data => data as FrostySdk.Ebx.RetargetTransformEntityData;
    public override string DisplayName => "RetargetTransform";

    public RetargetTransformEntity(FrostySdk.Ebx.RetargetTransformEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

