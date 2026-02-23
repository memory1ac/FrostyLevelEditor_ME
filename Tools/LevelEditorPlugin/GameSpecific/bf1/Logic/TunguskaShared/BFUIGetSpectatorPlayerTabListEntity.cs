namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetSpectatorPlayerTabListEntityData))]
public class BFUIGetSpectatorPlayerTabListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetSpectatorPlayerTabListEntityData>
{
    public new FrostySdk.Ebx.BFUIGetSpectatorPlayerTabListEntityData Data => data as FrostySdk.Ebx.BFUIGetSpectatorPlayerTabListEntityData;
    public override string DisplayName => "BFUIGetSpectatorPlayerTabList";

    public BFUIGetSpectatorPlayerTabListEntity(FrostySdk.Ebx.BFUIGetSpectatorPlayerTabListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

