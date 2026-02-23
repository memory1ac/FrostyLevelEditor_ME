namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINearbyMedicsDataProviderEntityData))]
public class UINearbyMedicsDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UINearbyMedicsDataProviderEntityData>
{
    public new FrostySdk.Ebx.UINearbyMedicsDataProviderEntityData Data => data as FrostySdk.Ebx.UINearbyMedicsDataProviderEntityData;
    public override string DisplayName => "UINearbyMedicsDataProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UINearbyMedicsDataProviderEntity(FrostySdk.Ebx.UINearbyMedicsDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

