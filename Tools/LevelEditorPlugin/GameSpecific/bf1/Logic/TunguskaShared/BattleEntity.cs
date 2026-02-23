namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BattleEntityData))]
public class BattleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BattleEntityData>
{
    public new FrostySdk.Ebx.BattleEntityData Data => data as FrostySdk.Ebx.BattleEntityData;
    public override string DisplayName => "Battle";

    public BattleEntity(FrostySdk.Ebx.BattleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

