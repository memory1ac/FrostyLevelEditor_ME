namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionOverallGraphicsQualityEntityData))]
public class BFUIProfileOptionOverallGraphicsQualityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionOverallGraphicsQualityEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionOverallGraphicsQualityEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionOverallGraphicsQualityEntityData;
    public override string DisplayName => "BFUIProfileOptionOverallGraphicsQuality";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionOverallGraphicsQualityEntity(FrostySdk.Ebx.BFUIProfileOptionOverallGraphicsQualityEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

