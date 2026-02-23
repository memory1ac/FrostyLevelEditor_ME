namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementRadialGradientEntityData))]
public class BFUIElementRadialGradientEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementRadialGradientEntityData>
{
    public new FrostySdk.Ebx.BFUIElementRadialGradientEntityData Data => data as FrostySdk.Ebx.BFUIElementRadialGradientEntityData;
    public override string DisplayName => "BFUIElementRadialGradient";

    public BFUIElementRadialGradientEntity(FrostySdk.Ebx.BFUIElementRadialGradientEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

