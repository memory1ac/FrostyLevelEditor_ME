namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISquadEntityData))]
public class UISquadEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISquadEntityData>
{
    public new FrostySdk.Ebx.UISquadEntityData Data => data as FrostySdk.Ebx.UISquadEntityData;
    public override string DisplayName => "UISquad";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISquadEntity(FrostySdk.Ebx.UISquadEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

