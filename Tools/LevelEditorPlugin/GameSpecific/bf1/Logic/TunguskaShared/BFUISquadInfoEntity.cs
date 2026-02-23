namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISquadInfoEntityData))]
public class BFUISquadInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISquadInfoEntityData>
{
    public new FrostySdk.Ebx.BFUISquadInfoEntityData Data => data as FrostySdk.Ebx.BFUISquadInfoEntityData;
    public override string DisplayName => "BFUISquadInfo";

    public BFUISquadInfoEntity(FrostySdk.Ebx.BFUISquadInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

