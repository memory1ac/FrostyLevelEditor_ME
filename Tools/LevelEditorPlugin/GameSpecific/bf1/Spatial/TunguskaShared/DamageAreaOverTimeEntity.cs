namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageAreaOverTimeEntityData))]
public class DamageAreaOverTimeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.DamageAreaOverTimeEntityData>
{
    public new FrostySdk.Ebx.DamageAreaOverTimeEntityData Data => data as FrostySdk.Ebx.DamageAreaOverTimeEntityData;

    public DamageAreaOverTimeEntity(FrostySdk.Ebx.DamageAreaOverTimeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

