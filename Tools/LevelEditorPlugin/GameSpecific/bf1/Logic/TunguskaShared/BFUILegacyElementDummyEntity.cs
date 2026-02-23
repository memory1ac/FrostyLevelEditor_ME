namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILegacyElementDummyEntityData))]
public class BFUILegacyElementDummyEntity : UIElementEntity, IEntityData<FrostySdk.Ebx.BFUILegacyElementDummyEntityData>
{
    public new FrostySdk.Ebx.BFUILegacyElementDummyEntityData Data => data as FrostySdk.Ebx.BFUILegacyElementDummyEntityData;
    public override string DisplayName => "BFUILegacyElementDummy";

    public BFUILegacyElementDummyEntity(FrostySdk.Ebx.BFUILegacyElementDummyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

