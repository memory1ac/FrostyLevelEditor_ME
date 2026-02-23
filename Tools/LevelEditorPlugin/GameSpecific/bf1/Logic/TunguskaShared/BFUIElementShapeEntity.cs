namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementShapeEntityData))]
public class BFUIElementShapeEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementShapeEntityData>
{
    public new FrostySdk.Ebx.BFUIElementShapeEntityData Data => data as FrostySdk.Ebx.BFUIElementShapeEntityData;
    public override string DisplayName => "BFUIElementShape";

    public BFUIElementShapeEntity(FrostySdk.Ebx.BFUIElementShapeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

