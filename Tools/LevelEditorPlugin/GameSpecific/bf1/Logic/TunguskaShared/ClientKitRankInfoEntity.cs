namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientKitRankInfoEntityData))]
public class ClientKitRankInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientKitRankInfoEntityData>
{
    public new FrostySdk.Ebx.ClientKitRankInfoEntityData Data => data as FrostySdk.Ebx.ClientKitRankInfoEntityData;
    public override string DisplayName => "ClientKitRankInfo";

    public ClientKitRankInfoEntity(FrostySdk.Ebx.ClientKitRankInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

