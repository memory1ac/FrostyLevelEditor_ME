namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TabletCommanderEntityData))]
public class TabletCommanderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TabletCommanderEntityData>
{
    public new FrostySdk.Ebx.TabletCommanderEntityData Data => data as FrostySdk.Ebx.TabletCommanderEntityData;
    public override string DisplayName => "TabletCommander";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TabletCommanderEntity(FrostySdk.Ebx.TabletCommanderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

