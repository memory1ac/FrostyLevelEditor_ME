namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommanderActionBaseData))]
public class CommanderActionBase : LogicEntity, IEntityData<FrostySdk.Ebx.CommanderActionBaseData>
{
    public new FrostySdk.Ebx.CommanderActionBaseData Data => data as FrostySdk.Ebx.CommanderActionBaseData;
    public override string DisplayName => "CommanderActionBase";

    public CommanderActionBase(FrostySdk.Ebx.CommanderActionBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

