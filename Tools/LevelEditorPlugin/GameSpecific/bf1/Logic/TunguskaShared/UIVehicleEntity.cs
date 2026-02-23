namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIVehicleEntityData))]
public class UIVehicleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIVehicleEntityData>
{
    public new FrostySdk.Ebx.UIVehicleEntityData Data => data as FrostySdk.Ebx.UIVehicleEntityData;
    public override string DisplayName => "UIVehicle";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIVehicleEntity(FrostySdk.Ebx.UIVehicleEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

