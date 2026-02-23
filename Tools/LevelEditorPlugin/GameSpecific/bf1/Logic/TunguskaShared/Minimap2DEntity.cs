namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.Minimap2DEntityData))]
public class Minimap2DEntity : LogicEntity, IEntityData<FrostySdk.Ebx.Minimap2DEntityData>
{
    public new FrostySdk.Ebx.Minimap2DEntityData Data => data as FrostySdk.Ebx.Minimap2DEntityData;
    public override string DisplayName => "Minimap2D";

    public Minimap2DEntity(FrostySdk.Ebx.Minimap2DEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

