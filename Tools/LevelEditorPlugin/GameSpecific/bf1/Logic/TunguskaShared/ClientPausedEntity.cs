namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientPausedEntityData))]
public class ClientPausedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientPausedEntityData>
{
    public new FrostySdk.Ebx.ClientPausedEntityData Data => data as FrostySdk.Ebx.ClientPausedEntityData;
    public override string DisplayName => "ClientPaused";

    public ClientPausedEntity(FrostySdk.Ebx.ClientPausedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

