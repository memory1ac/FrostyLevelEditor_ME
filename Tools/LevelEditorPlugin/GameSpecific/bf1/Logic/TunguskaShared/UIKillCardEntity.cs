namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIKillCardEntityData))]
public class UIKillCardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIKillCardEntityData>
{
    public new FrostySdk.Ebx.UIKillCardEntityData Data => data as FrostySdk.Ebx.UIKillCardEntityData;
    public override string DisplayName => "UIKillCard";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIKillCardEntity(FrostySdk.Ebx.UIKillCardEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

