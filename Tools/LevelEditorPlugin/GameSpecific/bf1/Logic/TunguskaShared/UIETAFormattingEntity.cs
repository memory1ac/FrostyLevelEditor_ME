namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIETAFormattingEntityData))]
public class UIETAFormattingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIETAFormattingEntityData>
{
    public new FrostySdk.Ebx.UIETAFormattingEntityData Data => data as FrostySdk.Ebx.UIETAFormattingEntityData;
    public override string DisplayName => "UIETAFormatting";

    public UIETAFormattingEntity(FrostySdk.Ebx.UIETAFormattingEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

