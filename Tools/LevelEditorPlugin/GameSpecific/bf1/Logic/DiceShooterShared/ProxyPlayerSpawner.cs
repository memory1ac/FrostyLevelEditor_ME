namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ProxyPlayerSpawnerData))]
public class ProxyPlayerSpawner : LogicEntity, IEntityData<FrostySdk.Ebx.ProxyPlayerSpawnerData>
{
    public new FrostySdk.Ebx.ProxyPlayerSpawnerData Data => data as FrostySdk.Ebx.ProxyPlayerSpawnerData;
    public override string DisplayName => "ProxyPlayerSpawner";

    public ProxyPlayerSpawner(FrostySdk.Ebx.ProxyPlayerSpawnerData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

