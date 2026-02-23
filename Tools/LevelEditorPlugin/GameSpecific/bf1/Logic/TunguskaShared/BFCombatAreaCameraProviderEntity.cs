namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFCombatAreaCameraProviderEntityData))]
public class BFCombatAreaCameraProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFCombatAreaCameraProviderEntityData>
{
    public new FrostySdk.Ebx.BFCombatAreaCameraProviderEntityData Data => data as FrostySdk.Ebx.BFCombatAreaCameraProviderEntityData;
    public override string DisplayName => "BFCombatAreaCameraProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFCombatAreaCameraProviderEntity(FrostySdk.Ebx.BFCombatAreaCameraProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

