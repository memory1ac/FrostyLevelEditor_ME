namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIDynamicWidgetReferenceEntityData))]
public class BFUIDynamicWidgetReferenceEntity : WidgetReferenceEntity, IEntityData<FrostySdk.Ebx.BFUIDynamicWidgetReferenceEntityData>
{
    public new FrostySdk.Ebx.BFUIDynamicWidgetReferenceEntityData Data => data as FrostySdk.Ebx.BFUIDynamicWidgetReferenceEntityData;

    public BFUIDynamicWidgetReferenceEntity(FrostySdk.Ebx.BFUIDynamicWidgetReferenceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

