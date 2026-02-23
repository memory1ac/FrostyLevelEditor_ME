namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutFlowListEntityData))]
public class BFUILayoutFlowListEntity : BFUILayoutEntity, IEntityData<FrostySdk.Ebx.BFUILayoutFlowListEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutFlowListEntityData Data => data as FrostySdk.Ebx.BFUILayoutFlowListEntityData;
    public override string DisplayName => "BFUILayoutFlowList";

    public BFUILayoutFlowListEntity(FrostySdk.Ebx.BFUILayoutFlowListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

