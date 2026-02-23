namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIKitSelectorEntityData))]
public class UIKitSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIKitSelectorEntityData>
{
    public new FrostySdk.Ebx.UIKitSelectorEntityData Data => data as FrostySdk.Ebx.UIKitSelectorEntityData;
    public override string DisplayName => "UIKitSelector";

    public UIKitSelectorEntity(FrostySdk.Ebx.UIKitSelectorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

