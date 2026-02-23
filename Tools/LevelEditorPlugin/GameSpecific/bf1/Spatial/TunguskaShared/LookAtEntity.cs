namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LookAtEntityData))]
public class LookAtEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.LookAtEntityData>
{
    public new FrostySdk.Ebx.LookAtEntityData Data => data as FrostySdk.Ebx.LookAtEntityData;

    public LookAtEntity(FrostySdk.Ebx.LookAtEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

