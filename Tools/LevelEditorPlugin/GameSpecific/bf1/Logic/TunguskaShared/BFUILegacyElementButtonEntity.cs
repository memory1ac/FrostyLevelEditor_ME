namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementButtonEntityData))]
public class BFUILegacyElementButtonEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementButtonEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementButtonEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementButtonEntityData;
    public override string DisplayName => "BFUILegacyElementButton";

    public BFUILegacyElementButtonEntity(FrostySdk.Ebx.BFUILegacyElementButtonEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

