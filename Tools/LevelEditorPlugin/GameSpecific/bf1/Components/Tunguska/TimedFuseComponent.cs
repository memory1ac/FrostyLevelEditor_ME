
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimedFuseComponentData))]
public class TimedFuseComponent : GameComponent, IEntityData<FrostySdk.Ebx.TimedFuseComponentData>
{
    public new FrostySdk.Ebx.TimedFuseComponentData Data => data as FrostySdk.Ebx.TimedFuseComponentData;
    public override string DisplayName => "TimedFuseComponent";

    public TimedFuseComponent(FrostySdk.Ebx.TimedFuseComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

