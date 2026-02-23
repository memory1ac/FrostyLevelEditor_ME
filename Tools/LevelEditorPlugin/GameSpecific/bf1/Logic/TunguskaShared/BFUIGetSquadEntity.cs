namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetSquadEntityData))]
public class BFUIGetSquadEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetSquadEntityData>
{
    public new FrostySdk.Ebx.BFUIGetSquadEntityData Data => data as FrostySdk.Ebx.BFUIGetSquadEntityData;
    public override string DisplayName => "BFUIGetSquad";

    public BFUIGetSquadEntity(FrostySdk.Ebx.BFUIGetSquadEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

