namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TerrainFireDamageEntityData))]
public class TerrainFireDamageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TerrainFireDamageEntityData>
{
    public new FrostySdk.Ebx.TerrainFireDamageEntityData Data => data as FrostySdk.Ebx.TerrainFireDamageEntityData;
    public override string DisplayName => "TerrainFireDamage";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TerrainFireDamageEntity(FrostySdk.Ebx.TerrainFireDamageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

