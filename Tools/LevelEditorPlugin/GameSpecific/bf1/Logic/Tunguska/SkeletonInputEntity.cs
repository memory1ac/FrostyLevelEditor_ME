namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SkeletonInputEntityData))]
public class SkeletonInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SkeletonInputEntityData>
{
    public new FrostySdk.Ebx.SkeletonInputEntityData Data => data as FrostySdk.Ebx.SkeletonInputEntityData;
    public override string DisplayName => "SkeletonInput";

    public SkeletonInputEntity(FrostySdk.Ebx.SkeletonInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

