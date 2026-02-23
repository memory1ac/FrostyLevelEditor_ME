namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIBestSquadEntityData))]
public class BFUIBestSquadEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIBestSquadEntityData>
{
    public new FrostySdk.Ebx.BFUIBestSquadEntityData Data => data as FrostySdk.Ebx.BFUIBestSquadEntityData;
    public override string DisplayName => "BFUIBestSquad";

    public BFUIBestSquadEntity(FrostySdk.Ebx.BFUIBestSquadEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

