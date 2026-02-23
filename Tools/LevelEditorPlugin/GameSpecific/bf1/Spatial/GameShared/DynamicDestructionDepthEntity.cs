namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DynamicDestructionDepthEntityData))]
public class DynamicDestructionDepthEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.DynamicDestructionDepthEntityData>
{
    public new FrostySdk.Ebx.DynamicDestructionDepthEntityData Data => data as FrostySdk.Ebx.DynamicDestructionDepthEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DynamicDestructionDepthEntity(FrostySdk.Ebx.DynamicDestructionDepthEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

