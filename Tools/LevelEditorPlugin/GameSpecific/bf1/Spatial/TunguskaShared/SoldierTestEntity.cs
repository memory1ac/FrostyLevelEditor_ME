namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierTestEntityData))]
public class SoldierTestEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.SoldierTestEntityData>
{
    public new FrostySdk.Ebx.SoldierTestEntityData Data => data as FrostySdk.Ebx.SoldierTestEntityData;

    public SoldierTestEntity(FrostySdk.Ebx.SoldierTestEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

