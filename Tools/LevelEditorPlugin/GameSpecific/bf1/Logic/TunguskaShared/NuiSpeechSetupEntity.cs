namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.NuiSpeechSetupEntityData))]
public class NuiSpeechSetupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.NuiSpeechSetupEntityData>
{
    public new FrostySdk.Ebx.NuiSpeechSetupEntityData Data => data as FrostySdk.Ebx.NuiSpeechSetupEntityData;
    public override string DisplayName => "NuiSpeechSetup";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public NuiSpeechSetupEntity(FrostySdk.Ebx.NuiSpeechSetupEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

