namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageInfoEntityData))]
public class DamageInfoEntity : GameComponentEntity, IEntityData<FrostySdk.Ebx.DamageInfoEntityData>
{
    public new FrostySdk.Ebx.DamageInfoEntityData Data => data as FrostySdk.Ebx.DamageInfoEntityData;

    public DamageInfoEntity(FrostySdk.Ebx.DamageInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

