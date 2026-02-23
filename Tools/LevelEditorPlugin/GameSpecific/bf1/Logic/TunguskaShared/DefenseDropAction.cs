namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DefenseDropActionData))]
public class DefenseDropAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.DefenseDropActionData>
{
    public new FrostySdk.Ebx.DefenseDropActionData Data => data as FrostySdk.Ebx.DefenseDropActionData;
    public override string DisplayName => "DefenseDropAction";

    public DefenseDropAction(FrostySdk.Ebx.DefenseDropActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

