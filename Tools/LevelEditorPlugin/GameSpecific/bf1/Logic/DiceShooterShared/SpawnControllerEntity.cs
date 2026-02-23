namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpawnControllerEntityData))]
public class SpawnControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpawnControllerEntityData>
{
    public new FrostySdk.Ebx.SpawnControllerEntityData Data => data as FrostySdk.Ebx.SpawnControllerEntityData;
    public override string DisplayName => "SpawnController";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SpawnControllerEntity(FrostySdk.Ebx.SpawnControllerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

