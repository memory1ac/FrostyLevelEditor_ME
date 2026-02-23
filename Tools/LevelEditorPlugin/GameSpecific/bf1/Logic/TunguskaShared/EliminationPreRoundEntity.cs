namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EliminationPreRoundEntityData))]
public class EliminationPreRoundEntity : PreRoundEntity, IEntityData<FrostySdk.Ebx.EliminationPreRoundEntityData>
{
    public new FrostySdk.Ebx.EliminationPreRoundEntityData Data => data as FrostySdk.Ebx.EliminationPreRoundEntityData;
    public override string DisplayName => "EliminationPreRound";

    public EliminationPreRoundEntity(FrostySdk.Ebx.EliminationPreRoundEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

