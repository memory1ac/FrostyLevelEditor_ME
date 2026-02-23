namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIVoiceEntityData))]
public class UIVoiceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIVoiceEntityData>
{
    public new FrostySdk.Ebx.UIVoiceEntityData Data => data as FrostySdk.Ebx.UIVoiceEntityData;
    public override string DisplayName => "UIVoice";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIVoiceEntity(FrostySdk.Ebx.UIVoiceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

