namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaMessageEntityData))]
public class SpartaMessageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaMessageEntityData>
{
    public new FrostySdk.Ebx.SpartaMessageEntityData Data => data as FrostySdk.Ebx.SpartaMessageEntityData;
    public override string DisplayName => "SpartaMessage";

    public SpartaMessageEntity(FrostySdk.Ebx.SpartaMessageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

