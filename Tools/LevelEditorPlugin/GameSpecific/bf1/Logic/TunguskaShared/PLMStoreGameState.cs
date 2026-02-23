namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PLMStoreGameStateData))]
public class PLMStoreGameState : LogicEntity, IEntityData<FrostySdk.Ebx.PLMStoreGameStateData>
{
    public new FrostySdk.Ebx.PLMStoreGameStateData Data => data as FrostySdk.Ebx.PLMStoreGameStateData;
    public override string DisplayName => "PLMStoreGameState";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PLMStoreGameState(FrostySdk.Ebx.PLMStoreGameStateData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

