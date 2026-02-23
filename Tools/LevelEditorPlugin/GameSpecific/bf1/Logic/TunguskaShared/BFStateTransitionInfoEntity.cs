namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFStateTransitionInfoEntityData))]
public class BFStateTransitionInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFStateTransitionInfoEntityData>
{
    public new FrostySdk.Ebx.BFStateTransitionInfoEntityData Data => data as FrostySdk.Ebx.BFStateTransitionInfoEntityData;
    public override string DisplayName => "BFStateTransitionInfo";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFStateTransitionInfoEntity(FrostySdk.Ebx.BFStateTransitionInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

