namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SwitchSoldierEntityData))]
public class SwitchSoldierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SwitchSoldierEntityData>
{
    public new FrostySdk.Ebx.SwitchSoldierEntityData Data => data as FrostySdk.Ebx.SwitchSoldierEntityData;
    public override string DisplayName => "SwitchSoldier";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SwitchSoldierEntity(FrostySdk.Ebx.SwitchSoldierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

