
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.WaypointComponentData))]
public class WaypointComponent : GameComponent, IEntityData<FrostySdk.Ebx.WaypointComponentData>
{
    public new FrostySdk.Ebx.WaypointComponentData Data => data as FrostySdk.Ebx.WaypointComponentData;
    public override string DisplayName => "WaypointComponent";

    public WaypointComponent(FrostySdk.Ebx.WaypointComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

