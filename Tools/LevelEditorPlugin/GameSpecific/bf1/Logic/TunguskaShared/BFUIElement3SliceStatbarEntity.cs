namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElement3SliceStatbarEntityData))]
public class BFUIElement3SliceStatbarEntity : BFUIElementStatbarBaseEntity, IEntityData<FrostySdk.Ebx.BFUIElement3SliceStatbarEntityData>
{
    public new FrostySdk.Ebx.BFUIElement3SliceStatbarEntityData Data => data as FrostySdk.Ebx.BFUIElement3SliceStatbarEntityData;
    public override string DisplayName => "BFUIElement3SliceStatbar";

    public BFUIElement3SliceStatbarEntity(FrostySdk.Ebx.BFUIElement3SliceStatbarEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

