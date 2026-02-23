namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementVideoEntityData))]
public class BFUILegacyElementVideoEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementVideoEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementVideoEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementVideoEntityData;
    public override string DisplayName => "BFUILegacyElementVideo";

    public BFUILegacyElementVideoEntity(FrostySdk.Ebx.BFUILegacyElementVideoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

