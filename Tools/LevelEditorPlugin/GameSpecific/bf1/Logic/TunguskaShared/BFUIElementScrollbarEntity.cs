namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementScrollbarEntityData))]
public class BFUIElementScrollbarEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementScrollbarEntityData>
{
    public new FrostySdk.Ebx.BFUIElementScrollbarEntityData Data => data as FrostySdk.Ebx.BFUIElementScrollbarEntityData;
    public override string DisplayName => "BFUIElementScrollbar";

    public BFUIElementScrollbarEntity(FrostySdk.Ebx.BFUIElementScrollbarEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

