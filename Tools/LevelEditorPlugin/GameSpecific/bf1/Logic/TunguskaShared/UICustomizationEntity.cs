namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICustomizationEntityData))]
public class UICustomizationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICustomizationEntityData>
{
    public new FrostySdk.Ebx.UICustomizationEntityData Data => data as FrostySdk.Ebx.UICustomizationEntityData;
    public override string DisplayName => "UICustomization";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UICustomizationEntity(FrostySdk.Ebx.UICustomizationEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

