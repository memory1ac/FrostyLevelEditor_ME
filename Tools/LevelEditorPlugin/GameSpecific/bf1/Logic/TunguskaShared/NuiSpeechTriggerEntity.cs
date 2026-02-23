namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.NuiSpeechTriggerEntityData))]
public class NuiSpeechTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.NuiSpeechTriggerEntityData>
{
    public new FrostySdk.Ebx.NuiSpeechTriggerEntityData Data => data as FrostySdk.Ebx.NuiSpeechTriggerEntityData;
    public override string DisplayName => "NuiSpeechTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public NuiSpeechTriggerEntity(FrostySdk.Ebx.NuiSpeechTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

