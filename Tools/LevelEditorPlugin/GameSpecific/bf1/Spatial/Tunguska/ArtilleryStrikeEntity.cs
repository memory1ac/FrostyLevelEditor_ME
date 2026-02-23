namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryStrikeEntityData))]
public class ArtilleryStrikeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.ArtilleryStrikeEntityData>
{
    public new FrostySdk.Ebx.ArtilleryStrikeEntityData Data => data as FrostySdk.Ebx.ArtilleryStrikeEntityData;

    public ArtilleryStrikeEntity(FrostySdk.Ebx.ArtilleryStrikeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

