namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommanderMapInfoEntityData))]
public class CommanderMapInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CommanderMapInfoEntityData>
{
    public new FrostySdk.Ebx.CommanderMapInfoEntityData Data => data as FrostySdk.Ebx.CommanderMapInfoEntityData;
    public override string DisplayName => "CommanderMapInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CommanderMapInfoEntity(FrostySdk.Ebx.CommanderMapInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

