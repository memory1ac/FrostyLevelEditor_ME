namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementColorizedFillEntityData))]
public class BFUIElementColorizedFillEntity : BFUIElementFillEntity, IEntityData<FrostySdk.Ebx.BFUIElementColorizedFillEntityData>
{
    public new FrostySdk.Ebx.BFUIElementColorizedFillEntityData Data => data as FrostySdk.Ebx.BFUIElementColorizedFillEntityData;
    public override string DisplayName => "BFUIElementColorizedFill";

    public BFUIElementColorizedFillEntity(FrostySdk.Ebx.BFUIElementColorizedFillEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

