namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIIconStateEntityData))]
public class BFUIIconStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIIconStateEntityData>
{
    public new FrostySdk.Ebx.BFUIIconStateEntityData Data => data as FrostySdk.Ebx.BFUIIconStateEntityData;
    public override string DisplayName => "BFUIIconState";

    public BFUIIconStateEntity(FrostySdk.Ebx.BFUIIconStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

