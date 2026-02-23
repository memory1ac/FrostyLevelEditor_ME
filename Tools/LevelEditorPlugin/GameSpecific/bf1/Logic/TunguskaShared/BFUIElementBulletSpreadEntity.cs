namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementBulletSpreadEntityData))]
public class BFUIElementBulletSpreadEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementBulletSpreadEntityData>
{
    public new FrostySdk.Ebx.BFUIElementBulletSpreadEntityData Data => data as FrostySdk.Ebx.BFUIElementBulletSpreadEntityData;
    public override string DisplayName => "BFUIElementBulletSpread";

    public BFUIElementBulletSpreadEntity(FrostySdk.Ebx.BFUIElementBulletSpreadEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

