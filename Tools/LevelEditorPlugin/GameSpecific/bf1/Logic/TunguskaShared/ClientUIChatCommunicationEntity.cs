namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientUIChatCommunicationEntityData))]
public class ClientUIChatCommunicationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientUIChatCommunicationEntityData>
{
    public new FrostySdk.Ebx.ClientUIChatCommunicationEntityData Data => data as FrostySdk.Ebx.ClientUIChatCommunicationEntityData;
    public override string DisplayName => "ClientUIChatCommunication";

    public ClientUIChatCommunicationEntity(FrostySdk.Ebx.ClientUIChatCommunicationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

