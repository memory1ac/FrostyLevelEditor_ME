namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomizationSoldierEntityData))]
public class CustomizationSoldierEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CustomizationSoldierEntityData>
{
    public new FrostySdk.Ebx.CustomizationSoldierEntityData Data => data as FrostySdk.Ebx.CustomizationSoldierEntityData;
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CustomizationSoldierEntity(FrostySdk.Ebx.CustomizationSoldierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

