namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFCharacterStateTriggerEntityData))]
public class BFCharacterStateTriggerEntity : CharacterStateTriggerEntity, IEntityData<FrostySdk.Ebx.BFCharacterStateTriggerEntityData>
{
    public new FrostySdk.Ebx.BFCharacterStateTriggerEntityData Data => data as FrostySdk.Ebx.BFCharacterStateTriggerEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFCharacterStateTriggerEntity(FrostySdk.Ebx.BFCharacterStateTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

