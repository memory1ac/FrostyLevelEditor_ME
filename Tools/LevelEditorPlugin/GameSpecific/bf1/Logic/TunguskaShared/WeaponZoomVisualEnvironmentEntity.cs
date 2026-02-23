namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WeaponZoomVisualEnvironmentEntityData))]
public class WeaponZoomVisualEnvironmentEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WeaponZoomVisualEnvironmentEntityData>
{
    public new FrostySdk.Ebx.WeaponZoomVisualEnvironmentEntityData Data => data as FrostySdk.Ebx.WeaponZoomVisualEnvironmentEntityData;
    public override string DisplayName => "WeaponZoomVisualEnvironment";

    public WeaponZoomVisualEnvironmentEntity(FrostySdk.Ebx.WeaponZoomVisualEnvironmentEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

