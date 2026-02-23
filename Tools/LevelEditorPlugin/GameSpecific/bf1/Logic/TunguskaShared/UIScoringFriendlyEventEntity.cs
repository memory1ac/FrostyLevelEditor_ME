namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIScoringFriendlyEventEntityData))]
public class UIScoringFriendlyEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIScoringFriendlyEventEntityData>
{
    public new FrostySdk.Ebx.UIScoringFriendlyEventEntityData Data => data as FrostySdk.Ebx.UIScoringFriendlyEventEntityData;
    public override string DisplayName => "UIScoringFriendlyEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIScoringFriendlyEventEntity(FrostySdk.Ebx.UIScoringFriendlyEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

