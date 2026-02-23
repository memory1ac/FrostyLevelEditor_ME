namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFTransformMixEntityData))]
public class BFTransformMixEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFTransformMixEntityData>
{
    public new FrostySdk.Ebx.BFTransformMixEntityData Data => data as FrostySdk.Ebx.BFTransformMixEntityData;
    public override string DisplayName => "BFTransformMix";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFTransformMixEntity(FrostySdk.Ebx.BFTransformMixEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

