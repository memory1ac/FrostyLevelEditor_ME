namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PLMRestoreGameStateData))]
public class PLMRestoreGameState : LogicEntity, IEntityData<FrostySdk.Ebx.PLMRestoreGameStateData>
{
    public new FrostySdk.Ebx.PLMRestoreGameStateData Data => data as FrostySdk.Ebx.PLMRestoreGameStateData;
    public override string DisplayName => "PLMRestoreGameState";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PLMRestoreGameState(FrostySdk.Ebx.PLMRestoreGameStateData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

