
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BlockSpottingComponentData))]
public class BlockSpottingComponent : GameComponent, IEntityData<FrostySdk.Ebx.BlockSpottingComponentData>
{
    public new FrostySdk.Ebx.BlockSpottingComponentData Data => data as FrostySdk.Ebx.BlockSpottingComponentData;
    public override string DisplayName => "BlockSpottingComponent";

    public BlockSpottingComponent(FrostySdk.Ebx.BlockSpottingComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

