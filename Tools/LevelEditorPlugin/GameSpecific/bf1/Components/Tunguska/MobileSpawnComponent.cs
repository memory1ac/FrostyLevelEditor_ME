
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MobileSpawnComponentData))]
public class MobileSpawnComponent : GameComponent, IEntityData<FrostySdk.Ebx.MobileSpawnComponentData>
{
    public new FrostySdk.Ebx.MobileSpawnComponentData Data => data as FrostySdk.Ebx.MobileSpawnComponentData;
    public override string DisplayName => "MobileSpawnComponent";

    public MobileSpawnComponent(FrostySdk.Ebx.MobileSpawnComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

