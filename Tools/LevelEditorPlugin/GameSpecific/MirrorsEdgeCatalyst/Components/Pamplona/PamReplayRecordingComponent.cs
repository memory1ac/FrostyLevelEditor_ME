
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReplayRecordingComponentData))]
	public class PamReplayRecordingComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamReplayRecordingComponentData>
	{
		public new FrostySdk.Ebx.PamReplayRecordingComponentData Data => data as FrostySdk.Ebx.PamReplayRecordingComponentData;
		public override string DisplayName => "PamReplayRecordingComponent";

		public PamReplayRecordingComponent(FrostySdk.Ebx.PamReplayRecordingComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

