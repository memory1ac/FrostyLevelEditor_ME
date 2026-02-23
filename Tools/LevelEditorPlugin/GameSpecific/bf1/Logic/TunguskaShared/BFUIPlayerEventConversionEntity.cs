namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerEventConversionEntityData))]
public class BFUIPlayerEventConversionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerEventConversionEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerEventConversionEntityData Data => data as FrostySdk.Ebx.BFUIPlayerEventConversionEntityData;
    public override string DisplayName => "BFUIPlayerEventConversion";

    public BFUIPlayerEventConversionEntity(FrostySdk.Ebx.BFUIPlayerEventConversionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

