namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIRepairToolCrosshairEntityData))]
public class UIRepairToolCrosshairEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIRepairToolCrosshairEntityData>
{
    public new FrostySdk.Ebx.UIRepairToolCrosshairEntityData Data => data as FrostySdk.Ebx.UIRepairToolCrosshairEntityData;
    public override string DisplayName => "UIRepairToolCrosshair";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIRepairToolCrosshairEntity(FrostySdk.Ebx.UIRepairToolCrosshairEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

