namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISettingsEntityData))]
public class UISettingsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISettingsEntityData>
{
    public new FrostySdk.Ebx.UISettingsEntityData Data => data as FrostySdk.Ebx.UISettingsEntityData;
    public override string DisplayName => "UISettings";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISettingsEntity(FrostySdk.Ebx.UISettingsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

