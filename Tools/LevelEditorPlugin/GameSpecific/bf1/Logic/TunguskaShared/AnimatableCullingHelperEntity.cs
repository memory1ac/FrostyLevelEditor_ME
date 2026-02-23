namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AnimatableCullingHelperEntityData))]
public class AnimatableCullingHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AnimatableCullingHelperEntityData>
{
    public new FrostySdk.Ebx.AnimatableCullingHelperEntityData Data => data as FrostySdk.Ebx.AnimatableCullingHelperEntityData;
    public override string DisplayName => "AnimatableCullingHelper";

    public AnimatableCullingHelperEntity(FrostySdk.Ebx.AnimatableCullingHelperEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

