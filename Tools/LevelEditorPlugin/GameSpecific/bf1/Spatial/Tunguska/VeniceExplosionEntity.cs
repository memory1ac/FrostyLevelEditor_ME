namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VeniceExplosionEntityData))]
public class VeniceExplosionEntity : ExplosionEntity, IEntityData<FrostySdk.Ebx.VeniceExplosionEntityData>
{
    public new FrostySdk.Ebx.VeniceExplosionEntityData Data => data as FrostySdk.Ebx.VeniceExplosionEntityData;

    public VeniceExplosionEntity(FrostySdk.Ebx.VeniceExplosionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

