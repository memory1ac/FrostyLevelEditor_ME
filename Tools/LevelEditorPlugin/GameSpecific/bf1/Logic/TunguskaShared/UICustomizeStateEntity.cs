namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICustomizeStateEntityData))]
public class UICustomizeStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICustomizeStateEntityData>
{
    public new FrostySdk.Ebx.UICustomizeStateEntityData Data => data as FrostySdk.Ebx.UICustomizeStateEntityData;
    public override string DisplayName => "UICustomizeState";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UICustomizeStateEntity(FrostySdk.Ebx.UICustomizeStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

