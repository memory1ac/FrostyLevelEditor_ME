namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientEnteredIngameEntityData))]
public class ClientEnteredIngameEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientEnteredIngameEntityData>
{
    public new FrostySdk.Ebx.ClientEnteredIngameEntityData Data => data as FrostySdk.Ebx.ClientEnteredIngameEntityData;
    public override string DisplayName => "ClientEnteredIngame";

    public ClientEnteredIngameEntity(FrostySdk.Ebx.ClientEnteredIngameEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

