namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementButtonEntityData))]
public class BFUIElementButtonEntity : BFUILegacyElementButtonEntity, IEntityData<FrostySdk.Ebx.BFUIElementButtonEntityData>
{
    public new FrostySdk.Ebx.BFUIElementButtonEntityData Data => data as FrostySdk.Ebx.BFUIElementButtonEntityData;
    public override string DisplayName => "BFUIElementButton";

    public BFUIElementButtonEntity(FrostySdk.Ebx.BFUIElementButtonEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

