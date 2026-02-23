
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ReleaseTimelineControlTrackData))]
public class ReleaseTimelineControlTrack : SchematicPinTrack, IEntityData<FrostySdk.Ebx.ReleaseTimelineControlTrackData>
{
    public new FrostySdk.Ebx.ReleaseTimelineControlTrackData Data => data as FrostySdk.Ebx.ReleaseTimelineControlTrackData;
    public override string DisplayName => "ReleaseTimelineControlTrack";

    public ReleaseTimelineControlTrack(FrostySdk.Ebx.ReleaseTimelineControlTrackData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

