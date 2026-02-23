namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBattleBriefingEventEntityData))]
public class UIBattleBriefingEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIBattleBriefingEventEntityData>
{
    public new FrostySdk.Ebx.UIBattleBriefingEventEntityData Data => data as FrostySdk.Ebx.UIBattleBriefingEventEntityData;
    public override string DisplayName => "UIBattleBriefingEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIBattleBriefingEventEntity(FrostySdk.Ebx.UIBattleBriefingEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

