namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetSpectatorsProviderEntityData))]
public class BFUIGetSpectatorsProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetSpectatorsProviderEntityData>
{
    public new FrostySdk.Ebx.BFUIGetSpectatorsProviderEntityData Data => data as FrostySdk.Ebx.BFUIGetSpectatorsProviderEntityData;
    public override string DisplayName => "BFUIGetSpectatorsProvider";

    public BFUIGetSpectatorsProviderEntity(FrostySdk.Ebx.BFUIGetSpectatorsProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

