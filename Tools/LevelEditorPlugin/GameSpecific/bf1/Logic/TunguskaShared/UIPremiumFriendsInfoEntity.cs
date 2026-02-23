namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPremiumFriendsInfoEntityData))]
public class UIPremiumFriendsInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIPremiumFriendsInfoEntityData>
{
    public new FrostySdk.Ebx.UIPremiumFriendsInfoEntityData Data => data as FrostySdk.Ebx.UIPremiumFriendsInfoEntityData;
    public override string DisplayName => "UIPremiumFriendsInfo";

    public UIPremiumFriendsInfoEntity(FrostySdk.Ebx.UIPremiumFriendsInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

