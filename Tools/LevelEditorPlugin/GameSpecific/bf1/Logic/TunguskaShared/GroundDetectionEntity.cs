namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GroundDetectionEntityData))]
public class GroundDetectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GroundDetectionEntityData>
{
    public new FrostySdk.Ebx.GroundDetectionEntityData Data => data as FrostySdk.Ebx.GroundDetectionEntityData;
    public override string DisplayName => "GroundDetection";

    public GroundDetectionEntity(FrostySdk.Ebx.GroundDetectionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

