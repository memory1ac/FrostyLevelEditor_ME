namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISoldierEntityData))]
public class UISoldierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISoldierEntityData>
{
    public new FrostySdk.Ebx.UISoldierEntityData Data => data as FrostySdk.Ebx.UISoldierEntityData;
    public override string DisplayName => "UISoldier";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISoldierEntity(FrostySdk.Ebx.UISoldierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

