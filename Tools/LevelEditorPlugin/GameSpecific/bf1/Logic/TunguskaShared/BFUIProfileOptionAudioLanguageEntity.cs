namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionAudioLanguageEntityData))]
public class BFUIProfileOptionAudioLanguageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionAudioLanguageEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionAudioLanguageEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionAudioLanguageEntityData;
    public override string DisplayName => "BFUIProfileOptionAudioLanguage";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionAudioLanguageEntity(FrostySdk.Ebx.BFUIProfileOptionAudioLanguageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

