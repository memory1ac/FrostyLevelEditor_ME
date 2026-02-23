namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementAnchorEntityData))]
public class BFUIElementAnchorEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementAnchorEntityData>
{
    public new FrostySdk.Ebx.BFUIElementAnchorEntityData Data => data as FrostySdk.Ebx.BFUIElementAnchorEntityData;
    public override string DisplayName => "BFUIElementAnchor";

    public BFUIElementAnchorEntity(FrostySdk.Ebx.BFUIElementAnchorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

