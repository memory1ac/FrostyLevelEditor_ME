namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaFrontEndAudioEntityData))]
public class SpartaFrontEndAudioEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaFrontEndAudioEntityData>
{
    public new FrostySdk.Ebx.SpartaFrontEndAudioEntityData Data => data as FrostySdk.Ebx.SpartaFrontEndAudioEntityData;
    public override string DisplayName => "SpartaFrontEndAudio";

    public SpartaFrontEndAudioEntity(FrostySdk.Ebx.SpartaFrontEndAudioEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

