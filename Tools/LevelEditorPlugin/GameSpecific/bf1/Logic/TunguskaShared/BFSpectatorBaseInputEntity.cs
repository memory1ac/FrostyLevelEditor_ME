namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorBaseInputEntityData))]
public class BFSpectatorBaseInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpectatorBaseInputEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorBaseInputEntityData Data => data as FrostySdk.Ebx.BFSpectatorBaseInputEntityData;
    public override string DisplayName => "BFSpectatorBaseInput";

    public BFSpectatorBaseInputEntity(FrostySdk.Ebx.BFSpectatorBaseInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

