
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClimbLadderComponentData))]
public class ClimbLadderComponent : GameComponent, IEntityData<FrostySdk.Ebx.ClimbLadderComponentData>
{
    public new FrostySdk.Ebx.ClimbLadderComponentData Data => data as FrostySdk.Ebx.ClimbLadderComponentData;
    public override string DisplayName => "ClimbLadderComponent";

    public ClimbLadderComponent(FrostySdk.Ebx.ClimbLadderComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

