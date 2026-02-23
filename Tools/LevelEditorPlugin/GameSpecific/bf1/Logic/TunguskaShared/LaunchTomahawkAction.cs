namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LaunchTomahawkActionData))]
public class LaunchTomahawkAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.LaunchTomahawkActionData>
{
    public new FrostySdk.Ebx.LaunchTomahawkActionData Data => data as FrostySdk.Ebx.LaunchTomahawkActionData;
    public override string DisplayName => "LaunchTomahawkAction";

    public LaunchTomahawkAction(FrostySdk.Ebx.LaunchTomahawkActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

