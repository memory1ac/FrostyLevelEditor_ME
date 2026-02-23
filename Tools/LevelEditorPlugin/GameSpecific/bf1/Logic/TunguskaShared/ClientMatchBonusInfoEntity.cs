namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientMatchBonusInfoEntityData))]
public class ClientMatchBonusInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientMatchBonusInfoEntityData>
{
    public new FrostySdk.Ebx.ClientMatchBonusInfoEntityData Data => data as FrostySdk.Ebx.ClientMatchBonusInfoEntityData;
    public override string DisplayName => "ClientMatchBonusInfo";

    public ClientMatchBonusInfoEntity(FrostySdk.Ebx.ClientMatchBonusInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

