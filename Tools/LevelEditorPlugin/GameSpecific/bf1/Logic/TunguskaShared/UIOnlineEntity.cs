namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIOnlineEntityData))]
public class UIOnlineEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIOnlineEntityData>
{
    public new FrostySdk.Ebx.UIOnlineEntityData Data => data as FrostySdk.Ebx.UIOnlineEntityData;
    public override string DisplayName => "UIOnline";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIOnlineEntity(FrostySdk.Ebx.UIOnlineEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

