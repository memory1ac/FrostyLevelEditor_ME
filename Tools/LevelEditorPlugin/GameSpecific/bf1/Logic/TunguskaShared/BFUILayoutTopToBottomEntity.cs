namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutTopToBottomEntityData))]
public class BFUILayoutTopToBottomEntity : BFUILayoutEntity, IEntityData<FrostySdk.Ebx.BFUILayoutTopToBottomEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutTopToBottomEntityData Data => data as FrostySdk.Ebx.BFUILayoutTopToBottomEntityData;
    public override string DisplayName => "BFUILayoutTopToBottom";

    public BFUILayoutTopToBottomEntity(FrostySdk.Ebx.BFUILayoutTopToBottomEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

