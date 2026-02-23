namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaitForTerrainEntityData))]
public class WaitForTerrainEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WaitForTerrainEntityData>
{
    public new FrostySdk.Ebx.WaitForTerrainEntityData Data => data as FrostySdk.Ebx.WaitForTerrainEntityData;
    public override string DisplayName => "WaitForTerrain";

    public WaitForTerrainEntity(FrostySdk.Ebx.WaitForTerrainEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

