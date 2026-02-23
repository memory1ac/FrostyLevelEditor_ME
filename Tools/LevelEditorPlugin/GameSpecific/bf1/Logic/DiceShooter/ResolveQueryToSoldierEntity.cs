namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ResolveQueryToSoldierEntityData))]
public class ResolveQueryToSoldierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ResolveQueryToSoldierEntityData>
{
    public new FrostySdk.Ebx.ResolveQueryToSoldierEntityData Data => data as FrostySdk.Ebx.ResolveQueryToSoldierEntityData;
    public override string DisplayName => "ResolveQueryToSoldier";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ResolveQueryToSoldierEntity(FrostySdk.Ebx.ResolveQueryToSoldierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

