namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICrosshairDataProviderEntityData))]
public class BFUICrosshairDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUICrosshairDataProviderEntityData>
{
    public new FrostySdk.Ebx.BFUICrosshairDataProviderEntityData Data => data as FrostySdk.Ebx.BFUICrosshairDataProviderEntityData;
    public override string DisplayName => "BFUICrosshairDataProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUICrosshairDataProviderEntity(FrostySdk.Ebx.BFUICrosshairDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

