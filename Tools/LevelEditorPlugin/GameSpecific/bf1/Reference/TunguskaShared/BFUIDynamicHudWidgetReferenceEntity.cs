namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIDynamicHudWidgetReferenceEntityData))]
public class BFUIDynamicHudWidgetReferenceEntity : WidgetReferenceEntity, IEntityData<FrostySdk.Ebx.BFUIDynamicHudWidgetReferenceEntityData>
{
    public new FrostySdk.Ebx.BFUIDynamicHudWidgetReferenceEntityData Data => data as FrostySdk.Ebx.BFUIDynamicHudWidgetReferenceEntityData;

    public BFUIDynamicHudWidgetReferenceEntity(FrostySdk.Ebx.BFUIDynamicHudWidgetReferenceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

