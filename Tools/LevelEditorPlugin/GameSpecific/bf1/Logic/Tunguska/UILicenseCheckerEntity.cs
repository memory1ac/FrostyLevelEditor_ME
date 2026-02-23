namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILicenseCheckerEntityData))]
public class UILicenseCheckerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILicenseCheckerEntityData>
{
    public new FrostySdk.Ebx.UILicenseCheckerEntityData Data => data as FrostySdk.Ebx.UILicenseCheckerEntityData;
    public override string DisplayName => "UILicenseChecker";

    public UILicenseCheckerEntity(FrostySdk.Ebx.UILicenseCheckerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

