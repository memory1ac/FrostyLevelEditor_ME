namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementTextFieldEntityData))]
public class BFUIElementTextFieldEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementTextFieldEntityData>
{
    public new FrostySdk.Ebx.BFUIElementTextFieldEntityData Data => data as FrostySdk.Ebx.BFUIElementTextFieldEntityData;
    public override string DisplayName => "BFUIElementTextField";

    public BFUIElementTextFieldEntity(FrostySdk.Ebx.BFUIElementTextFieldEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

