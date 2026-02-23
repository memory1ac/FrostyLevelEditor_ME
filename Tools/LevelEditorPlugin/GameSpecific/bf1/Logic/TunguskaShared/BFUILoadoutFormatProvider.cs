namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILoadoutFormatProviderData))]
public class BFUILoadoutFormatProvider : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILoadoutFormatProviderData>
{
    public new FrostySdk.Ebx.BFUILoadoutFormatProviderData Data => data as FrostySdk.Ebx.BFUILoadoutFormatProviderData;
    public override string DisplayName => "BFUILoadoutFormatProvider";

    public BFUILoadoutFormatProvider(FrostySdk.Ebx.BFUILoadoutFormatProviderData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

