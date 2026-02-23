namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SquadStatusEntityData))]
public class SquadStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SquadStatusEntityData>
{
    public new FrostySdk.Ebx.SquadStatusEntityData Data => data as FrostySdk.Ebx.SquadStatusEntityData;
    public override string DisplayName => "SquadStatus";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SquadStatusEntity(FrostySdk.Ebx.SquadStatusEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

