namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementPathEntityData))]
public class BFUIElementPathEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementPathEntityData>
{
    public new FrostySdk.Ebx.BFUIElementPathEntityData Data => data as FrostySdk.Ebx.BFUIElementPathEntityData;
    public override string DisplayName => "BFUIElementPath";

    public BFUIElementPathEntity(FrostySdk.Ebx.BFUIElementPathEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

