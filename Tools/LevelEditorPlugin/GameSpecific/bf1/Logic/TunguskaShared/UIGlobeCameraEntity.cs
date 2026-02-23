namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIGlobeCameraEntityData))]
public class UIGlobeCameraEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIGlobeCameraEntityData>
{
    public new FrostySdk.Ebx.UIGlobeCameraEntityData Data => data as FrostySdk.Ebx.UIGlobeCameraEntityData;
    public override string DisplayName => "UIGlobeCamera";

    public UIGlobeCameraEntity(FrostySdk.Ebx.UIGlobeCameraEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

