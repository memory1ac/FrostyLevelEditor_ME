namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISupplyCrateEntityData))]
public class UISupplyCrateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISupplyCrateEntityData>
{
    public new FrostySdk.Ebx.UISupplyCrateEntityData Data => data as FrostySdk.Ebx.UISupplyCrateEntityData;
    public override string DisplayName => "UISupplyCrate";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UISupplyCrateEntity(FrostySdk.Ebx.UISupplyCrateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

