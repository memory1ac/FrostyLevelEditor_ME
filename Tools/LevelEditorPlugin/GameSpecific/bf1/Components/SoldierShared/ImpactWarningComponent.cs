
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ImpactWarningComponentData))]
public class ImpactWarningComponent : GameComponent, IEntityData<FrostySdk.Ebx.ImpactWarningComponentData>
{
    public new FrostySdk.Ebx.ImpactWarningComponentData Data => data as FrostySdk.Ebx.ImpactWarningComponentData;
    public override string DisplayName => "ImpactWarningComponent";

    public ImpactWarningComponent(FrostySdk.Ebx.ImpactWarningComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

