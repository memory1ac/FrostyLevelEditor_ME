namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementButtonBarButtonEntityData))]
public class BFUIElementButtonBarButtonEntity : DiceUIInputActionListenerElement, IEntityData<FrostySdk.Ebx.BFUIElementButtonBarButtonEntityData>
{
    public new FrostySdk.Ebx.BFUIElementButtonBarButtonEntityData Data => data as FrostySdk.Ebx.BFUIElementButtonBarButtonEntityData;
    public override string DisplayName => "BFUIElementButtonBarButton";

    public BFUIElementButtonBarButtonEntity(FrostySdk.Ebx.BFUIElementButtonBarButtonEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

