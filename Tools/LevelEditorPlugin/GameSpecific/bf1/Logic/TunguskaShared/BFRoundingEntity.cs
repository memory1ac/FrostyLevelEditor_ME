namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFRoundingEntityData))]
public class BFRoundingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFRoundingEntityData>
{
    public new FrostySdk.Ebx.BFRoundingEntityData Data => data as FrostySdk.Ebx.BFRoundingEntityData;
    public override string DisplayName => "BFRounding";

    public BFRoundingEntity(FrostySdk.Ebx.BFRoundingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

