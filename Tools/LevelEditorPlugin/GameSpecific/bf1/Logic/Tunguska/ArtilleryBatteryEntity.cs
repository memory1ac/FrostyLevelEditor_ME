namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ArtilleryBatteryEntityData))]
public class ArtilleryBatteryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ArtilleryBatteryEntityData>
{
    public new FrostySdk.Ebx.ArtilleryBatteryEntityData Data => data as FrostySdk.Ebx.ArtilleryBatteryEntityData;
    public override string DisplayName => "ArtilleryBattery";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ArtilleryBatteryEntity(FrostySdk.Ebx.ArtilleryBatteryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

