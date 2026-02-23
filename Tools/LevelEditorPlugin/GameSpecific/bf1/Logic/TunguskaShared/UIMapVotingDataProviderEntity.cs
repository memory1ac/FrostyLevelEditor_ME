namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMapVotingDataProviderEntityData))]
public class UIMapVotingDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMapVotingDataProviderEntityData>
{
    public new FrostySdk.Ebx.UIMapVotingDataProviderEntityData Data => data as FrostySdk.Ebx.UIMapVotingDataProviderEntityData;
    public override string DisplayName => "UIMapVotingDataProvider";

    public UIMapVotingDataProviderEntity(FrostySdk.Ebx.UIMapVotingDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

