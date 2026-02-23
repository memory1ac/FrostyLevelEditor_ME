
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectVariationComponentData))]
public class ObjectVariationComponent : GameComponent, IEntityData<FrostySdk.Ebx.ObjectVariationComponentData>
{
    public new FrostySdk.Ebx.ObjectVariationComponentData Data => data as FrostySdk.Ebx.ObjectVariationComponentData;
    public override string DisplayName => "ObjectVariationComponent";

    public ObjectVariationComponent(FrostySdk.Ebx.ObjectVariationComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

