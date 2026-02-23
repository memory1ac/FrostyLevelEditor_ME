namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaSendMessageEntityData))]
public class SpartaSendMessageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaSendMessageEntityData>
{
    public new FrostySdk.Ebx.SpartaSendMessageEntityData Data => data as FrostySdk.Ebx.SpartaSendMessageEntityData;
    public override string DisplayName => "SpartaSendMessage";

    public SpartaSendMessageEntity(FrostySdk.Ebx.SpartaSendMessageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

