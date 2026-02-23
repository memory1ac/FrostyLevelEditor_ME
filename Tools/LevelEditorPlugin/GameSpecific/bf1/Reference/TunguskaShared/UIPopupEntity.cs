namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPopupEntityData))]
public class UIPopupEntity : LogicReferenceObject, IEntityData<FrostySdk.Ebx.UIPopupEntityData>
{
    public new FrostySdk.Ebx.UIPopupEntityData Data => data as FrostySdk.Ebx.UIPopupEntityData;

    public UIPopupEntity(FrostySdk.Ebx.UIPopupEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

