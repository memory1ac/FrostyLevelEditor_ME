namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementSpectatorOverviewIconsEntityData))]
public class BFUIElementSpectatorOverviewIconsEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementSpectatorOverviewIconsEntityData>
{
    public new FrostySdk.Ebx.BFUIElementSpectatorOverviewIconsEntityData Data => data as FrostySdk.Ebx.BFUIElementSpectatorOverviewIconsEntityData;
    public override string DisplayName => "BFUIElementSpectatorOverviewIcons";

    public BFUIElementSpectatorOverviewIconsEntity(FrostySdk.Ebx.BFUIElementSpectatorOverviewIconsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

