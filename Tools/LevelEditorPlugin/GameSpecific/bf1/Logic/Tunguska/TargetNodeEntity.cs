namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetNodeEntityData))]
public class TargetNodeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TargetNodeEntityData>
{
    public new FrostySdk.Ebx.TargetNodeEntityData Data => data as FrostySdk.Ebx.TargetNodeEntityData;
    public override string DisplayName => "TargetNode";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TargetNodeEntity(FrostySdk.Ebx.TargetNodeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

