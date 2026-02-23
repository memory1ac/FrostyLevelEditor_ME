namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.NotifyPsPlusFeatureEntityData))]
public class NotifyPsPlusFeatureEntity : LogicEntity, IEntityData<FrostySdk.Ebx.NotifyPsPlusFeatureEntityData>
{
    public new FrostySdk.Ebx.NotifyPsPlusFeatureEntityData Data => data as FrostySdk.Ebx.NotifyPsPlusFeatureEntityData;
    public override string DisplayName => "NotifyPsPlusFeature";

    public NotifyPsPlusFeatureEntity(FrostySdk.Ebx.NotifyPsPlusFeatureEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

