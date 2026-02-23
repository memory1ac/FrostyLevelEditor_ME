namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoipEntityData))]
public class VoipEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoipEntityData>
{
    public new FrostySdk.Ebx.VoipEntityData Data => data as FrostySdk.Ebx.VoipEntityData;
    public override string DisplayName => "Voip";

    public VoipEntity(FrostySdk.Ebx.VoipEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

