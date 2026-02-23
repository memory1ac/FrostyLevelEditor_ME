namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoiceOverInfoEntityData))]
public class VoiceOverInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoiceOverInfoEntityData>
{
    public new FrostySdk.Ebx.VoiceOverInfoEntityData Data => data as FrostySdk.Ebx.VoiceOverInfoEntityData;
    public override string DisplayName => "VoiceOverInfo";

    public VoiceOverInfoEntity(FrostySdk.Ebx.VoiceOverInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

