namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetTeamVehiclesEntityData))]
public class BFUIGetTeamVehiclesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetTeamVehiclesEntityData>
{
    public new FrostySdk.Ebx.BFUIGetTeamVehiclesEntityData Data => data as FrostySdk.Ebx.BFUIGetTeamVehiclesEntityData;
    public override string DisplayName => "BFUIGetTeamVehicles";

    public BFUIGetTeamVehiclesEntity(FrostySdk.Ebx.BFUIGetTeamVehiclesEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

