namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDeploy3DVehicleSelectorEntityData))]
public class UIDeploy3DVehicleSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDeploy3DVehicleSelectorEntityData>
{
    public new FrostySdk.Ebx.UIDeploy3DVehicleSelectorEntityData Data => data as FrostySdk.Ebx.UIDeploy3DVehicleSelectorEntityData;
    public override string DisplayName => "UIDeploy3DVehicleSelector";

    public UIDeploy3DVehicleSelectorEntity(FrostySdk.Ebx.UIDeploy3DVehicleSelectorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

