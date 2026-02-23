namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TileAreaEntityData))]
public class TileAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TileAreaEntityData>
{
    public new FrostySdk.Ebx.TileAreaEntityData Data => data as FrostySdk.Ebx.TileAreaEntityData;
    public override string DisplayName => "TileArea";

    public TileAreaEntity(FrostySdk.Ebx.TileAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

