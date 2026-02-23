
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFStaticModelHealthComponentData))]
public class BFStaticModelHealthComponent : StaticModelHealthComponent, IEntityData<FrostySdk.Ebx.BFStaticModelHealthComponentData>
{
    public new FrostySdk.Ebx.BFStaticModelHealthComponentData Data => data as FrostySdk.Ebx.BFStaticModelHealthComponentData;
    public override string DisplayName => "BFStaticModelHealthComponent";

    public BFStaticModelHealthComponent(FrostySdk.Ebx.BFStaticModelHealthComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

