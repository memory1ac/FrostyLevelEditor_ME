namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementSimpleMeshEntityData))]
public class BFUIElementSimpleMeshEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementSimpleMeshEntityData>
{
    public new FrostySdk.Ebx.BFUIElementSimpleMeshEntityData Data => data as FrostySdk.Ebx.BFUIElementSimpleMeshEntityData;
    public override string DisplayName => "BFUIElementSimpleMesh";

    public BFUIElementSimpleMeshEntity(FrostySdk.Ebx.BFUIElementSimpleMeshEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

