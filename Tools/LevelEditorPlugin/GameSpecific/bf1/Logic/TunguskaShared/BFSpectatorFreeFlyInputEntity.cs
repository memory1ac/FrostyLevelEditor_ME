namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorFreeFlyInputEntityData))]
public class BFSpectatorFreeFlyInputEntity : BFSpectatorBaseInputEntity, IEntityData<FrostySdk.Ebx.BFSpectatorFreeFlyInputEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorFreeFlyInputEntityData Data => data as FrostySdk.Ebx.BFSpectatorFreeFlyInputEntityData;
    public override string DisplayName => "BFSpectatorFreeFlyInput";

    public BFSpectatorFreeFlyInputEntity(FrostySdk.Ebx.BFSpectatorFreeFlyInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

