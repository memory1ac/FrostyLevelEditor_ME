namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementFillEntityData))]
public class BFUIElementFillEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementFillEntityData>
{
    public new FrostySdk.Ebx.BFUIElementFillEntityData Data => data as FrostySdk.Ebx.BFUIElementFillEntityData;
    public override string DisplayName => "BFUIElementFill";

    public BFUIElementFillEntity(FrostySdk.Ebx.BFUIElementFillEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

