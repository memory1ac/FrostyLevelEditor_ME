namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AudioEngineLogicEntityData))]
public class AudioEngineLogicEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AudioEngineLogicEntityData>
{
    public new FrostySdk.Ebx.AudioEngineLogicEntityData Data => data as FrostySdk.Ebx.AudioEngineLogicEntityData;
    public override string DisplayName => "AudioEngineLogic";

    public AudioEngineLogicEntity(FrostySdk.Ebx.AudioEngineLogicEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

