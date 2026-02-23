namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFPlayerFilterExtEntityData))]
public class BFPlayerFilterExtEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFPlayerFilterExtEntityData>
{
    public new FrostySdk.Ebx.BFPlayerFilterExtEntityData Data => data as FrostySdk.Ebx.BFPlayerFilterExtEntityData;
    public override string DisplayName => "BFPlayerFilterExt";

    public BFPlayerFilterExtEntity(FrostySdk.Ebx.BFPlayerFilterExtEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

