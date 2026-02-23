namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementFillEntityData))]
public class BFUILegacyElementFillEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementFillEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementFillEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementFillEntityData;
    public override string DisplayName => "BFUILegacyElementFill";

    public BFUILegacyElementFillEntity(FrostySdk.Ebx.BFUILegacyElementFillEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

