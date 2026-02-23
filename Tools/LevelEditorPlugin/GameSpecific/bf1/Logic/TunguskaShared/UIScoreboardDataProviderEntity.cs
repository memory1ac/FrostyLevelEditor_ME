namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIScoreboardDataProviderEntityData))]
public class UIScoreboardDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIScoreboardDataProviderEntityData>
{
    public new FrostySdk.Ebx.UIScoreboardDataProviderEntityData Data => data as FrostySdk.Ebx.UIScoreboardDataProviderEntityData;
    public override string DisplayName => "UIScoreboardDataProvider";

    public UIScoreboardDataProviderEntity(FrostySdk.Ebx.UIScoreboardDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

