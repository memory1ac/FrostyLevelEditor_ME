namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugAttachmentFilterEntityData))]
public class DebugAttachmentFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugAttachmentFilterEntityData>
{
    public new FrostySdk.Ebx.DebugAttachmentFilterEntityData Data => data as FrostySdk.Ebx.DebugAttachmentFilterEntityData;
    public override string DisplayName => "DebugAttachmentFilter";

    public DebugAttachmentFilterEntity(FrostySdk.Ebx.DebugAttachmentFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

