namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIWorldIconsElementData))]
public class BFUIWorldIconsElement : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIWorldIconsElementData>
{
    public new FrostySdk.Ebx.BFUIWorldIconsElementData Data => data as FrostySdk.Ebx.BFUIWorldIconsElementData;
    public override string DisplayName => "BFUIWorldIconsElement";

    public BFUIWorldIconsElement(FrostySdk.Ebx.BFUIWorldIconsElementData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

