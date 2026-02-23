namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementGraphEntityData))]
public class BFUIElementGraphEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementGraphEntityData>
{
    public new FrostySdk.Ebx.BFUIElementGraphEntityData Data => data as FrostySdk.Ebx.BFUIElementGraphEntityData;
    public override string DisplayName => "BFUIElementGraph";

    public BFUIElementGraphEntity(FrostySdk.Ebx.BFUIElementGraphEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

