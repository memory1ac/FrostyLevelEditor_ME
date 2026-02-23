namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetSoldierEntityData))]
public class BFUIGetSoldierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetSoldierEntityData>
{
    public new FrostySdk.Ebx.BFUIGetSoldierEntityData Data => data as FrostySdk.Ebx.BFUIGetSoldierEntityData;
    public override string DisplayName => "BFUIGetSoldier";

    public BFUIGetSoldierEntity(FrostySdk.Ebx.BFUIGetSoldierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

