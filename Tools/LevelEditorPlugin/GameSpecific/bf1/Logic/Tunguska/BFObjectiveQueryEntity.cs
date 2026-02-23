namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFObjectiveQueryEntityData))]
public class BFObjectiveQueryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFObjectiveQueryEntityData>
{
    public new FrostySdk.Ebx.BFObjectiveQueryEntityData Data => data as FrostySdk.Ebx.BFObjectiveQueryEntityData;
    public override string DisplayName => "BFObjectiveQuery";

    public BFObjectiveQueryEntity(FrostySdk.Ebx.BFObjectiveQueryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

