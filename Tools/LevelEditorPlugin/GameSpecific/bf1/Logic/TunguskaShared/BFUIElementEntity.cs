namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementEntityData))]
public class BFUIElementEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementEntityData>
{
    public new FrostySdk.Ebx.BFUIElementEntityData Data => data as FrostySdk.Ebx.BFUIElementEntityData;
    public override string DisplayName => "BFUIElement";

    public BFUIElementEntity(FrostySdk.Ebx.BFUIElementEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

