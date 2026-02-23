namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugAttachmentFilterIteratorEntityData))]
public class DebugAttachmentFilterIteratorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugAttachmentFilterIteratorEntityData>
{
    public new FrostySdk.Ebx.DebugAttachmentFilterIteratorEntityData Data => data as FrostySdk.Ebx.DebugAttachmentFilterIteratorEntityData;
    public override string DisplayName => "DebugAttachmentFilterIterator";

    public DebugAttachmentFilterIteratorEntity(FrostySdk.Ebx.DebugAttachmentFilterIteratorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

