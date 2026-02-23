namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommanderEntityData))]
public class CommanderEntity : GameComponentEntity, IEntityData<FrostySdk.Ebx.CommanderEntityData>
{
    public new FrostySdk.Ebx.CommanderEntityData Data => data as FrostySdk.Ebx.CommanderEntityData;

    public CommanderEntity(FrostySdk.Ebx.CommanderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

