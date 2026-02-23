namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFOrderTargetEntityData))]
public class BFOrderTargetEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.BFOrderTargetEntityData>
{
    public new FrostySdk.Ebx.BFOrderTargetEntityData Data => data as FrostySdk.Ebx.BFOrderTargetEntityData;

    public BFOrderTargetEntity(FrostySdk.Ebx.BFOrderTargetEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

