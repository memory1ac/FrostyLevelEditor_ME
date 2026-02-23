namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementVideoEntityData))]
public class BFUIElementVideoEntity : BFUILegacyElementVideoEntity, IEntityData<FrostySdk.Ebx.BFUIElementVideoEntityData>
{
    public new FrostySdk.Ebx.BFUIElementVideoEntityData Data => data as FrostySdk.Ebx.BFUIElementVideoEntityData;
    public override string DisplayName => "BFUIElementVideo";

    public BFUIElementVideoEntity(FrostySdk.Ebx.BFUIElementVideoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

