namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UINPXTooltipEntityData))]
public class UINPXTooltipEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UINPXTooltipEntityData>
{
    public new FrostySdk.Ebx.UINPXTooltipEntityData Data => data as FrostySdk.Ebx.UINPXTooltipEntityData;
    public override string DisplayName => "UINPXTooltip";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UINPXTooltipEntity(FrostySdk.Ebx.UINPXTooltipEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

