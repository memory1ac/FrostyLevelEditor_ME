namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIWidgetEntityData))]
public class BFUIWidgetEntity : UIWidgetEntity, IEntityData<FrostySdk.Ebx.BFUIWidgetEntityData>
{
    public new FrostySdk.Ebx.BFUIWidgetEntityData Data => data as FrostySdk.Ebx.BFUIWidgetEntityData;
    public override string DisplayName => "BFUIWidget";

    public BFUIWidgetEntity(FrostySdk.Ebx.BFUIWidgetEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

