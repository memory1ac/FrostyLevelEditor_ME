namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientCashInfoEntityData))]
public class ClientCashInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientCashInfoEntityData>
{
    public new FrostySdk.Ebx.ClientCashInfoEntityData Data => data as FrostySdk.Ebx.ClientCashInfoEntityData;
    public override string DisplayName => "ClientCashInfo";

    public ClientCashInfoEntity(FrostySdk.Ebx.ClientCashInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

