namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISquadboardDataProviderEntityData))]
public class UISquadboardDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISquadboardDataProviderEntityData>
{
    public new FrostySdk.Ebx.UISquadboardDataProviderEntityData Data => data as FrostySdk.Ebx.UISquadboardDataProviderEntityData;
    public override string DisplayName => "UISquadboardDataProvider";

    public UISquadboardDataProviderEntity(FrostySdk.Ebx.UISquadboardDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

