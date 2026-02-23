namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFObjectiveEntityData))]
public class BFObjectiveEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFObjectiveEntityData>
{
    public new FrostySdk.Ebx.BFObjectiveEntityData Data => data as FrostySdk.Ebx.BFObjectiveEntityData;
    public override string DisplayName => "BFObjective";

    public BFObjectiveEntity(FrostySdk.Ebx.BFObjectiveEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

