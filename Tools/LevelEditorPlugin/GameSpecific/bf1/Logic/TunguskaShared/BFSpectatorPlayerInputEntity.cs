namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorPlayerInputEntityData))]
public class BFSpectatorPlayerInputEntity : BFSpectatorBaseInputEntity, IEntityData<FrostySdk.Ebx.BFSpectatorPlayerInputEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorPlayerInputEntityData Data => data as FrostySdk.Ebx.BFSpectatorPlayerInputEntityData;
    public override string DisplayName => "BFSpectatorPlayerInput";

    public BFSpectatorPlayerInputEntity(FrostySdk.Ebx.BFSpectatorPlayerInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

