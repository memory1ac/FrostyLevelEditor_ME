namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ActionMessageQueueEntityData))]
public class ActionMessageQueueEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ActionMessageQueueEntityData>
{
    public new FrostySdk.Ebx.ActionMessageQueueEntityData Data => data as FrostySdk.Ebx.ActionMessageQueueEntityData;
    public override string DisplayName => "ActionMessageQueue";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ActionMessageQueueEntity(FrostySdk.Ebx.ActionMessageQueueEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

