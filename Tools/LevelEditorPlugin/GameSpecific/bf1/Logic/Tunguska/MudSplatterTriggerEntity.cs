namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MudSplatterTriggerEntityData))]
public class MudSplatterTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MudSplatterTriggerEntityData>
{
    public new FrostySdk.Ebx.MudSplatterTriggerEntityData Data => data as FrostySdk.Ebx.MudSplatterTriggerEntityData;
    public override string DisplayName => "MudSplatterTrigger";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public MudSplatterTriggerEntity(FrostySdk.Ebx.MudSplatterTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

