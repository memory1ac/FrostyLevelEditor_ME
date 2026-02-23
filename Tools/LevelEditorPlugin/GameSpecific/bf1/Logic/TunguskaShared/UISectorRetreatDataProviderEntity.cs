namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISectorRetreatDataProviderEntityData))]
public class UISectorRetreatDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISectorRetreatDataProviderEntityData>
{
    public new FrostySdk.Ebx.UISectorRetreatDataProviderEntityData Data => data as FrostySdk.Ebx.UISectorRetreatDataProviderEntityData;
    public override string DisplayName => "UISectorRetreatDataProvider";

    public UISectorRetreatDataProviderEntity(FrostySdk.Ebx.UISectorRetreatDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

