namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementEditBoxEntityData))]
public class BFUIElementEditBoxEntity : DiceUITypingInputListenerElement, IEntityData<FrostySdk.Ebx.BFUIElementEditBoxEntityData>
{
    public new FrostySdk.Ebx.BFUIElementEditBoxEntityData Data => data as FrostySdk.Ebx.BFUIElementEditBoxEntityData;
    public override string DisplayName => "BFUIElementEditBox";

    public BFUIElementEditBoxEntity(FrostySdk.Ebx.BFUIElementEditBoxEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

