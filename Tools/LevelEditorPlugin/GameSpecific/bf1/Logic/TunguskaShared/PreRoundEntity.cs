namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PreRoundEntityData))]
public class PreRoundEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PreRoundEntityData>
{
    public new FrostySdk.Ebx.PreRoundEntityData Data => data as FrostySdk.Ebx.PreRoundEntityData;
    public override string DisplayName => "PreRound";

    public PreRoundEntity(FrostySdk.Ebx.PreRoundEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

