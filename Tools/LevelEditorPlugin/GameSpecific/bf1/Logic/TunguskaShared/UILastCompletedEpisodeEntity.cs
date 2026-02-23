namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILastCompletedEpisodeEntityData))]
public class UILastCompletedEpisodeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILastCompletedEpisodeEntityData>
{
    public new FrostySdk.Ebx.UILastCompletedEpisodeEntityData Data => data as FrostySdk.Ebx.UILastCompletedEpisodeEntityData;
    public override string DisplayName => "UILastCompletedEpisode";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILastCompletedEpisodeEntity(FrostySdk.Ebx.UILastCompletedEpisodeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

