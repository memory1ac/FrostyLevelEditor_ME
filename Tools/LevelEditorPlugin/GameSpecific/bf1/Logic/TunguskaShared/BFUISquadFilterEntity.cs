namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISquadFilterEntityData))]
public class BFUISquadFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISquadFilterEntityData>
{
    public new FrostySdk.Ebx.BFUISquadFilterEntityData Data => data as FrostySdk.Ebx.BFUISquadFilterEntityData;
    public override string DisplayName => "BFUISquadFilter";

    public BFUISquadFilterEntity(FrostySdk.Ebx.BFUISquadFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

