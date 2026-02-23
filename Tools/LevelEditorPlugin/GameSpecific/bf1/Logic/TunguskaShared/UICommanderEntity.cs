namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommanderEntityData))]
public class UICommanderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICommanderEntityData>
{
    public new FrostySdk.Ebx.UICommanderEntityData Data => data as FrostySdk.Ebx.UICommanderEntityData;
    public override string DisplayName => "UICommander";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UICommanderEntity(FrostySdk.Ebx.UICommanderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

