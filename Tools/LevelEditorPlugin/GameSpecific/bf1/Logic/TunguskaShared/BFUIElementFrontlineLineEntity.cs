namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementFrontlineLineEntityData))]
public class BFUIElementFrontlineLineEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementFrontlineLineEntityData>
{
    public new FrostySdk.Ebx.BFUIElementFrontlineLineEntityData Data => data as FrostySdk.Ebx.BFUIElementFrontlineLineEntityData;
    public override string DisplayName => "BFUIElementFrontlineLine";

    public BFUIElementFrontlineLineEntity(FrostySdk.Ebx.BFUIElementFrontlineLineEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

