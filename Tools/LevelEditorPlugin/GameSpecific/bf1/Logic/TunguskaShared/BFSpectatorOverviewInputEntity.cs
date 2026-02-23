namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorOverviewInputEntityData))]
public class BFSpectatorOverviewInputEntity : BFSpectatorBaseInputEntity, IEntityData<FrostySdk.Ebx.BFSpectatorOverviewInputEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorOverviewInputEntityData Data => data as FrostySdk.Ebx.BFSpectatorOverviewInputEntityData;
    public override string DisplayName => "BFSpectatorOverviewInput";

    public BFSpectatorOverviewInputEntity(FrostySdk.Ebx.BFSpectatorOverviewInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

