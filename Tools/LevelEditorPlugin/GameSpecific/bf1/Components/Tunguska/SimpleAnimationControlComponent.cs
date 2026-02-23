
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleAnimationControlComponentData))]
public class SimpleAnimationControlComponent : GameComponent, IEntityData<FrostySdk.Ebx.SimpleAnimationControlComponentData>
{
    public new FrostySdk.Ebx.SimpleAnimationControlComponentData Data => data as FrostySdk.Ebx.SimpleAnimationControlComponentData;
    public override string DisplayName => "SimpleAnimationControlComponent";

    public SimpleAnimationControlComponent(FrostySdk.Ebx.SimpleAnimationControlComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

