namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ContextualMeleeEntityData))]
public class ContextualMeleeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ContextualMeleeEntityData>
{
    public new FrostySdk.Ebx.ContextualMeleeEntityData Data => data as FrostySdk.Ebx.ContextualMeleeEntityData;
    public override string DisplayName => "ContextualMelee";

    public ContextualMeleeEntity(FrostySdk.Ebx.ContextualMeleeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

