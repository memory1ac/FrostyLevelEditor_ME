namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EarlyWarningActionData))]
public class EarlyWarningAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.EarlyWarningActionData>
{
    public new FrostySdk.Ebx.EarlyWarningActionData Data => data as FrostySdk.Ebx.EarlyWarningActionData;
    public override string DisplayName => "EarlyWarningAction";

    public EarlyWarningAction(FrostySdk.Ebx.EarlyWarningActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

