namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISPChapterInfoProviderEntityData))]
public class UISPChapterInfoProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISPChapterInfoProviderEntityData>
{
    public new FrostySdk.Ebx.UISPChapterInfoProviderEntityData Data => data as FrostySdk.Ebx.UISPChapterInfoProviderEntityData;
    public override string DisplayName => "UISPChapterInfoProvider";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISPChapterInfoProviderEntity(FrostySdk.Ebx.UISPChapterInfoProviderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

