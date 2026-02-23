namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetEntityData))]
public class TargetEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.TargetEntityData>
{
    public new FrostySdk.Ebx.TargetEntityData Data => data as FrostySdk.Ebx.TargetEntityData;

    public TargetEntity(FrostySdk.Ebx.TargetEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

