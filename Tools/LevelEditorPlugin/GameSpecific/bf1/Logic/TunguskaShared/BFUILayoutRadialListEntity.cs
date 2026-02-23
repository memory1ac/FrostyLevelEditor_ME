namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutRadialListEntityData))]
public class BFUILayoutRadialListEntity : BFUILayoutEntity, IEntityData<FrostySdk.Ebx.BFUILayoutRadialListEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutRadialListEntityData Data => data as FrostySdk.Ebx.BFUILayoutRadialListEntityData;
    public override string DisplayName => "BFUILayoutRadialList";

    public BFUILayoutRadialListEntity(FrostySdk.Ebx.BFUILayoutRadialListEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

