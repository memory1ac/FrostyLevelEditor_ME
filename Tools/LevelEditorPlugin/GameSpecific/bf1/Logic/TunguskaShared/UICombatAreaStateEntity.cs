namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICombatAreaStateEntityData))]
public class UICombatAreaStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICombatAreaStateEntityData>
{
    public new FrostySdk.Ebx.UICombatAreaStateEntityData Data => data as FrostySdk.Ebx.UICombatAreaStateEntityData;
    public override string DisplayName => "UICombatAreaState";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UICombatAreaStateEntity(FrostySdk.Ebx.UICombatAreaStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

