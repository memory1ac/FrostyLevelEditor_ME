
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.JammingComponentData))]
public class JammingComponent : GameComponent, IEntityData<FrostySdk.Ebx.JammingComponentData>
{
    public new FrostySdk.Ebx.JammingComponentData Data => data as FrostySdk.Ebx.JammingComponentData;
    public override string DisplayName => "JammingComponent";

    public JammingComponent(FrostySdk.Ebx.JammingComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

