namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UITooltipEntityData))]
public class UITooltipEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UITooltipEntityData>
{
    public new FrostySdk.Ebx.UITooltipEntityData Data => data as FrostySdk.Ebx.UITooltipEntityData;
    public override string DisplayName => "UITooltip";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UITooltipEntity(FrostySdk.Ebx.UITooltipEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

