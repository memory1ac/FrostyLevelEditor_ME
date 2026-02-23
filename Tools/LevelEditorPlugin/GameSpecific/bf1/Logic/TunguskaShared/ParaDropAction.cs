namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ParaDropActionData))]
public class ParaDropAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.ParaDropActionData>
{
    public new FrostySdk.Ebx.ParaDropActionData Data => data as FrostySdk.Ebx.ParaDropActionData;
    public override string DisplayName => "ParaDropAction";

    public ParaDropAction(FrostySdk.Ebx.ParaDropActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

