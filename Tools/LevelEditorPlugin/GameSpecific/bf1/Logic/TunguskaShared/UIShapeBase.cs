namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIShapeBaseData))]
public class UIShapeBase : BFUIWidgetEntity, IEntityData<FrostySdk.Ebx.UIShapeBaseData>
{
    public new FrostySdk.Ebx.UIShapeBaseData Data => data as FrostySdk.Ebx.UIShapeBaseData;
    public override string DisplayName => "UIShapeBase";

    public UIShapeBase(FrostySdk.Ebx.UIShapeBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

