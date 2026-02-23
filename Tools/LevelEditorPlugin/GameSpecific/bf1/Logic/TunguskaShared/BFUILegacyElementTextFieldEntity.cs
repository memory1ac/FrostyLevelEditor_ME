namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementTextFieldEntityData))]
public class BFUILegacyElementTextFieldEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementTextFieldEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementTextFieldEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementTextFieldEntityData;
    public override string DisplayName => "BFUILegacyElementTextField";

    public BFUILegacyElementTextFieldEntity(FrostySdk.Ebx.BFUILegacyElementTextFieldEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

