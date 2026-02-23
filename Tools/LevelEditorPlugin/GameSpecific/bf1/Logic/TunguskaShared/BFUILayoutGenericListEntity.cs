namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutGenericListEntityData))]
public class BFUILayoutGenericListEntity : BFUILayoutEntity, IEntityData<FrostySdk.Ebx.BFUILayoutGenericListEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutGenericListEntityData Data => data as FrostySdk.Ebx.BFUILayoutGenericListEntityData;
    public override string DisplayName => "BFUILayoutGenericList";

    public BFUILayoutGenericListEntity(FrostySdk.Ebx.BFUILayoutGenericListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

