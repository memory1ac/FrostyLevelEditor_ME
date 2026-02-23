namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFInputRestrictionEntityData))]
public class BFInputRestrictionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFInputRestrictionEntityData>
{
    public new FrostySdk.Ebx.BFInputRestrictionEntityData Data => data as FrostySdk.Ebx.BFInputRestrictionEntityData;
    public override string DisplayName => "BFInputRestriction";

    public BFInputRestrictionEntity(FrostySdk.Ebx.BFInputRestrictionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

