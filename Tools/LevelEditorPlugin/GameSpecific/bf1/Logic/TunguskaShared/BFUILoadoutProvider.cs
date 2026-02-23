namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILoadoutProviderData))]
public class BFUILoadoutProvider : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILoadoutProviderData>
{
    public new FrostySdk.Ebx.BFUILoadoutProviderData Data => data as FrostySdk.Ebx.BFUILoadoutProviderData;
    public override string DisplayName => "BFUILoadoutProvider";

    public BFUILoadoutProvider(FrostySdk.Ebx.BFUILoadoutProviderData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

