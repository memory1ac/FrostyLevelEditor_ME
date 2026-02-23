namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaFrontEndCoreEntityData))]
public class SpartaFrontEndCoreEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaFrontEndCoreEntityData>
{
    public new FrostySdk.Ebx.SpartaFrontEndCoreEntityData Data => data as FrostySdk.Ebx.SpartaFrontEndCoreEntityData;
    public override string DisplayName => "SpartaFrontEndCore";

    public SpartaFrontEndCoreEntity(FrostySdk.Ebx.SpartaFrontEndCoreEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

