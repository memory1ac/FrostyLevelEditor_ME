namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFCurrentLevelObjectiveData))]
public class BFCurrentLevelObjective : LogicEntity, IEntityData<FrostySdk.Ebx.BFCurrentLevelObjectiveData>
{
    public new FrostySdk.Ebx.BFCurrentLevelObjectiveData Data => data as FrostySdk.Ebx.BFCurrentLevelObjectiveData;
    public override string DisplayName => "BFCurrentLevelObjective";

    public BFCurrentLevelObjective(FrostySdk.Ebx.BFCurrentLevelObjectiveData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

