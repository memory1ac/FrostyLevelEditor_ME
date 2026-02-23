namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CameraDistanceTresholdEntityData))]
public class CameraDistanceTresholdEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CameraDistanceTresholdEntityData>
{
    public new FrostySdk.Ebx.CameraDistanceTresholdEntityData Data => data as FrostySdk.Ebx.CameraDistanceTresholdEntityData;
    public override string DisplayName => "CameraDistanceTreshold";

    public CameraDistanceTresholdEntity(FrostySdk.Ebx.CameraDistanceTresholdEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

