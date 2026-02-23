namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerDeathTypeCompareEntityData))]
public class PlayerDeathTypeCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerDeathTypeCompareEntityData>
{
    public new FrostySdk.Ebx.PlayerDeathTypeCompareEntityData Data => data as FrostySdk.Ebx.PlayerDeathTypeCompareEntityData;
    public override string DisplayName => "PlayerDeathTypeCompare";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public PlayerDeathTypeCompareEntity(FrostySdk.Ebx.PlayerDeathTypeCompareEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

