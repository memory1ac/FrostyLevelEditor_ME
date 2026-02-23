namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIFrontLineSpawnWidgetData))]
public class UIFrontLineSpawnWidget : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIFrontLineSpawnWidgetData>
{
    public new FrostySdk.Ebx.UIFrontLineSpawnWidgetData Data => data as FrostySdk.Ebx.UIFrontLineSpawnWidgetData;
    public override string DisplayName => "UIFrontLineSpawnWidget";

    public UIFrontLineSpawnWidget(FrostySdk.Ebx.UIFrontLineSpawnWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

