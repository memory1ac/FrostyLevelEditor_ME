namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutGroupListEntityData))]
public class BFUILayoutGroupListEntity : BFUILayoutEntity, IEntityData<FrostySdk.Ebx.BFUILayoutGroupListEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutGroupListEntityData Data => data as FrostySdk.Ebx.BFUILayoutGroupListEntityData;
    public override string DisplayName => "BFUILayoutGroupList";

    public BFUILayoutGroupListEntity(FrostySdk.Ebx.BFUILayoutGroupListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

