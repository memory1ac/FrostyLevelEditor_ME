namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIStringBuilderEntityData))]
public class UIStringBuilderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIStringBuilderEntityData>
{
    public new FrostySdk.Ebx.UIStringBuilderEntityData Data => data as FrostySdk.Ebx.UIStringBuilderEntityData;
    public override string DisplayName => "UIStringBuilder";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIStringBuilderEntity(FrostySdk.Ebx.UIStringBuilderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

