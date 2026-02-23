namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.InvertedInputRestrictionEntityData))]
public class InvertedInputRestrictionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InvertedInputRestrictionEntityData>
{
    public new FrostySdk.Ebx.InvertedInputRestrictionEntityData Data => data as FrostySdk.Ebx.InvertedInputRestrictionEntityData;
    public override string DisplayName => "InvertedInputRestriction";

    public InvertedInputRestrictionEntity(FrostySdk.Ebx.InvertedInputRestrictionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

