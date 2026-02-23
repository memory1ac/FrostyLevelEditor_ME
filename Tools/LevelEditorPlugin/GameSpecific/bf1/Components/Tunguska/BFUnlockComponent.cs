
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUnlockComponentData))]
public class BFUnlockComponent : UnlockComponent, IEntityData<FrostySdk.Ebx.BFUnlockComponentData>
{
    public new FrostySdk.Ebx.BFUnlockComponentData Data => data as FrostySdk.Ebx.BFUnlockComponentData;
    public override string DisplayName => "BFUnlockComponent";

    public BFUnlockComponent(FrostySdk.Ebx.BFUnlockComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

