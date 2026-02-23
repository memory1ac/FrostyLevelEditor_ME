namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementCustomEntityData))]
public class BFUILegacyElementCustomEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementCustomEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementCustomEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementCustomEntityData;
    public override string DisplayName => "BFUILegacyElementCustom";

    public BFUILegacyElementCustomEntity(FrostySdk.Ebx.BFUILegacyElementCustomEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

