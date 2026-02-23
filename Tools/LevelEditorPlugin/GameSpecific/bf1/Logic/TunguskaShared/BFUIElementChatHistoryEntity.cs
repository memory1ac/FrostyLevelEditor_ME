namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementChatHistoryEntityData))]
public class BFUIElementChatHistoryEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementChatHistoryEntityData>
{
    public new FrostySdk.Ebx.BFUIElementChatHistoryEntityData Data => data as FrostySdk.Ebx.BFUIElementChatHistoryEntityData;
    public override string DisplayName => "BFUIElementChatHistory";

    public BFUIElementChatHistoryEntity(FrostySdk.Ebx.BFUIElementChatHistoryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

