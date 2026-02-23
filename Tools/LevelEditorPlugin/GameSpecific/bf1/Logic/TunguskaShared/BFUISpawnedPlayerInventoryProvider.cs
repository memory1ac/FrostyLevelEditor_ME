namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISpawnedPlayerInventoryProviderData))]
public class BFUISpawnedPlayerInventoryProvider : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISpawnedPlayerInventoryProviderData>
{
    public new FrostySdk.Ebx.BFUISpawnedPlayerInventoryProviderData Data => data as FrostySdk.Ebx.BFUISpawnedPlayerInventoryProviderData;
    public override string DisplayName => "BFUISpawnedPlayerInventoryProvider";

    public BFUISpawnedPlayerInventoryProvider(FrostySdk.Ebx.BFUISpawnedPlayerInventoryProviderData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

