namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMenuListEntryEntityData))]
public class UIMenuListEntryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMenuListEntryEntityData>
{
    public new FrostySdk.Ebx.UIMenuListEntryEntityData Data => data as FrostySdk.Ebx.UIMenuListEntryEntityData;
    public override string DisplayName => "UIMenuListEntry";

    public UIMenuListEntryEntity(FrostySdk.Ebx.UIMenuListEntryEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

