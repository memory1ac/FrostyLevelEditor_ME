namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HighValueTargetActionData))]
public class HighValueTargetAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.HighValueTargetActionData>
{
    public new FrostySdk.Ebx.HighValueTargetActionData Data => data as FrostySdk.Ebx.HighValueTargetActionData;
    public override string DisplayName => "HighValueTargetAction";

    public HighValueTargetAction(FrostySdk.Ebx.HighValueTargetActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

