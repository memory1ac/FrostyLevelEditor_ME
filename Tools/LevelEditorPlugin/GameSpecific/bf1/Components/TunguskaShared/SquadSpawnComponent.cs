
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SquadSpawnComponentData))]
public class SquadSpawnComponent : GameComponent, IEntityData<FrostySdk.Ebx.SquadSpawnComponentData>
{
    public new FrostySdk.Ebx.SquadSpawnComponentData Data => data as FrostySdk.Ebx.SquadSpawnComponentData;
    public override string DisplayName => "SquadSpawnComponent";

    public SquadSpawnComponent(FrostySdk.Ebx.SquadSpawnComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

