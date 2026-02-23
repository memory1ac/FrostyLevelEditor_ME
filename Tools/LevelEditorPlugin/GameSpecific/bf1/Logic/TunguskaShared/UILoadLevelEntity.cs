namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILoadLevelEntityData))]
public class UILoadLevelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILoadLevelEntityData>
{
    public new FrostySdk.Ebx.UILoadLevelEntityData Data => data as FrostySdk.Ebx.UILoadLevelEntityData;
    public override string DisplayName => "UILoadLevel";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UILoadLevelEntity(FrostySdk.Ebx.UILoadLevelEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

