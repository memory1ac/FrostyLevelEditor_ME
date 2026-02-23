namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIGameJoinEntityData))]
public class UIGameJoinEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIGameJoinEntityData>
{
    public new FrostySdk.Ebx.UIGameJoinEntityData Data => data as FrostySdk.Ebx.UIGameJoinEntityData;
    public override string DisplayName => "UIGameJoin";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIGameJoinEntity(FrostySdk.Ebx.UIGameJoinEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

