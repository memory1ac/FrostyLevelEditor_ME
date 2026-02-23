namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILoadoutEditorEntityData))]
public class BFUILoadoutEditorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILoadoutEditorEntityData>
{
    public new FrostySdk.Ebx.BFUILoadoutEditorEntityData Data => data as FrostySdk.Ebx.BFUILoadoutEditorEntityData;
    public override string DisplayName => "BFUILoadoutEditor";

    public BFUILoadoutEditorEntity(FrostySdk.Ebx.BFUILoadoutEditorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

