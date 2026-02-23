namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIRoundOutcomeEntityData))]
public class UIRoundOutcomeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIRoundOutcomeEntityData>
{
    public new FrostySdk.Ebx.UIRoundOutcomeEntityData Data => data as FrostySdk.Ebx.UIRoundOutcomeEntityData;
    public override string DisplayName => "UIRoundOutcome";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIRoundOutcomeEntity(FrostySdk.Ebx.UIRoundOutcomeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

