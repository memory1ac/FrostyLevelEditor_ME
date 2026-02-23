namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementCurvedTextEntityData))]
public class BFUIElementCurvedTextEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementCurvedTextEntityData>
{
    public new FrostySdk.Ebx.BFUIElementCurvedTextEntityData Data => data as FrostySdk.Ebx.BFUIElementCurvedTextEntityData;
    public override string DisplayName => "BFUIElementCurvedText";

    public BFUIElementCurvedTextEntity(FrostySdk.Ebx.BFUIElementCurvedTextEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

