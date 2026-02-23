namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISquadPresentationDataProviderEntityData))]
public class UISquadPresentationDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISquadPresentationDataProviderEntityData>
{
    public new FrostySdk.Ebx.UISquadPresentationDataProviderEntityData Data => data as FrostySdk.Ebx.UISquadPresentationDataProviderEntityData;
    public override string DisplayName => "UISquadPresentationDataProvider";

    public UISquadPresentationDataProviderEntity(FrostySdk.Ebx.UISquadPresentationDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

