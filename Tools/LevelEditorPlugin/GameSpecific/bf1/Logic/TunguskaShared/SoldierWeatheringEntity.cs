namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierWeatheringEntityData))]
public class SoldierWeatheringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoldierWeatheringEntityData>
{
    public new FrostySdk.Ebx.SoldierWeatheringEntityData Data => data as FrostySdk.Ebx.SoldierWeatheringEntityData;
    public override string DisplayName => "SoldierWeathering";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SoldierWeatheringEntity(FrostySdk.Ebx.SoldierWeatheringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

