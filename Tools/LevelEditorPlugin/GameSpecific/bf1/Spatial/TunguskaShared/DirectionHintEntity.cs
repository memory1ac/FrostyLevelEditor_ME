namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DirectionHintEntityData))]
public class DirectionHintEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.DirectionHintEntityData>
{
    public new FrostySdk.Ebx.DirectionHintEntityData Data => data as FrostySdk.Ebx.DirectionHintEntityData;

    public DirectionHintEntity(FrostySdk.Ebx.DirectionHintEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

