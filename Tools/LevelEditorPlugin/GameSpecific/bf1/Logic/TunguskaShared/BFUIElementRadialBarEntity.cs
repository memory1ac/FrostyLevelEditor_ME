namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementRadialBarEntityData))]
public class BFUIElementRadialBarEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementRadialBarEntityData>
{
    public new FrostySdk.Ebx.BFUIElementRadialBarEntityData Data => data as FrostySdk.Ebx.BFUIElementRadialBarEntityData;
    public override string DisplayName => "BFUIElementRadialBar";

    public BFUIElementRadialBarEntity(FrostySdk.Ebx.BFUIElementRadialBarEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

