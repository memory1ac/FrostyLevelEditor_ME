namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIHitIndicatorEntityData))]
public class UIHitIndicatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIHitIndicatorEntityData>
{
    public new FrostySdk.Ebx.UIHitIndicatorEntityData Data => data as FrostySdk.Ebx.UIHitIndicatorEntityData;
    public override string DisplayName => "UIHitIndicator";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIHitIndicatorEntity(FrostySdk.Ebx.UIHitIndicatorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

