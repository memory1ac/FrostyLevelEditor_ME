namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetNodeQueryEntityData))]
public class TargetNodeQueryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TargetNodeQueryEntityData>
{
    public new FrostySdk.Ebx.TargetNodeQueryEntityData Data => data as FrostySdk.Ebx.TargetNodeQueryEntityData;
    public override string DisplayName => "TargetNodeQuery";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TargetNodeQueryEntity(FrostySdk.Ebx.TargetNodeQueryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

