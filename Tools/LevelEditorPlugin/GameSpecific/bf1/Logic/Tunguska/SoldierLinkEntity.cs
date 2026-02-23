namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierLinkEntityData))]
public class SoldierLinkEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoldierLinkEntityData>
{
    public new FrostySdk.Ebx.SoldierLinkEntityData Data => data as FrostySdk.Ebx.SoldierLinkEntityData;
    public override string DisplayName => "SoldierLink";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public SoldierLinkEntity(FrostySdk.Ebx.SoldierLinkEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

