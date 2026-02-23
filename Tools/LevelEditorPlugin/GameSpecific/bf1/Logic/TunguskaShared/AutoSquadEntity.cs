namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoSquadEntityData))]
public class AutoSquadEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoSquadEntityData>
{
    public new FrostySdk.Ebx.AutoSquadEntityData Data => data as FrostySdk.Ebx.AutoSquadEntityData;
    public override string DisplayName => "AutoSquad";

    public AutoSquadEntity(FrostySdk.Ebx.AutoSquadEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

