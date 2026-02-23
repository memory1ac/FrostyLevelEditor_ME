namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ProxyAttackActionData))]
public class ProxyAttackAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.ProxyAttackActionData>
{
    public new FrostySdk.Ebx.ProxyAttackActionData Data => data as FrostySdk.Ebx.ProxyAttackActionData;
    public override string DisplayName => "ProxyAttackAction";

    public ProxyAttackAction(FrostySdk.Ebx.ProxyAttackActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

