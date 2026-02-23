namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CopyWheelRotationEntityData))]
public class CopyWheelRotationEntity : ComponentTransformEntityBase, IEntityData<FrostySdk.Ebx.CopyWheelRotationEntityData>
{
    public new FrostySdk.Ebx.CopyWheelRotationEntityData Data => data as FrostySdk.Ebx.CopyWheelRotationEntityData;
    public override string DisplayName => "CopyWheelRotation";

    public CopyWheelRotationEntity(FrostySdk.Ebx.CopyWheelRotationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

