namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDamageTakenIndicatorEntityData))]
public class UIDamageTakenIndicatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDamageTakenIndicatorEntityData>
{
    public new FrostySdk.Ebx.UIDamageTakenIndicatorEntityData Data => data as FrostySdk.Ebx.UIDamageTakenIndicatorEntityData;
    public override string DisplayName => "UIDamageTakenIndicator";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIDamageTakenIndicatorEntity(FrostySdk.Ebx.UIDamageTakenIndicatorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

