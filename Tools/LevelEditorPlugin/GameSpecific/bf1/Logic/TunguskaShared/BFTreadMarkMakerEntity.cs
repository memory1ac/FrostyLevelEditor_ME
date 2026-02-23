namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFTreadMarkMakerEntityData))]
public class BFTreadMarkMakerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFTreadMarkMakerEntityData>
{
    public new FrostySdk.Ebx.BFTreadMarkMakerEntityData Data => data as FrostySdk.Ebx.BFTreadMarkMakerEntityData;
    public override string DisplayName => "BFTreadMarkMaker";

    public BFTreadMarkMakerEntity(FrostySdk.Ebx.BFTreadMarkMakerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

