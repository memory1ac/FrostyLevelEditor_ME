namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIKeybindingsDataProviderEntityData))]
public class BFUIKeybindingsDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIKeybindingsDataProviderEntityData>
{
    public new FrostySdk.Ebx.BFUIKeybindingsDataProviderEntityData Data => data as FrostySdk.Ebx.BFUIKeybindingsDataProviderEntityData;
    public override string DisplayName => "BFUIKeybindingsDataProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIKeybindingsDataProviderEntity(FrostySdk.Ebx.BFUIKeybindingsDataProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

