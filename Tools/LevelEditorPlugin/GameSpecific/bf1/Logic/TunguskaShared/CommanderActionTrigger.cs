namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommanderActionTriggerData))]
public class CommanderActionTrigger : LogicEntity, IEntityData<FrostySdk.Ebx.CommanderActionTriggerData>
{
    public new FrostySdk.Ebx.CommanderActionTriggerData Data => data as FrostySdk.Ebx.CommanderActionTriggerData;
    public override string DisplayName => "CommanderActionTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CommanderActionTrigger(FrostySdk.Ebx.CommanderActionTriggerData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

