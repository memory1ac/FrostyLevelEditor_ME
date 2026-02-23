namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementStatbarEntityData))]
public class BFUIElementStatbarEntity : BFUIElementStatbarBaseEntity, IEntityData<FrostySdk.Ebx.BFUIElementStatbarEntityData>
{
    public new FrostySdk.Ebx.BFUIElementStatbarEntityData Data => data as FrostySdk.Ebx.BFUIElementStatbarEntityData;
    public override string DisplayName => "BFUIElementStatbar";

    public BFUIElementStatbarEntity(FrostySdk.Ebx.BFUIElementStatbarEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

