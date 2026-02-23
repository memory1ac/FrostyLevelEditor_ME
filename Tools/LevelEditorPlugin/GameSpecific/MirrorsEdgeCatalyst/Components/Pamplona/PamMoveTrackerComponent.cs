
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMoveTrackerComponentData))]
	public class PamMoveTrackerComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamMoveTrackerComponentData>
	{
		public new FrostySdk.Ebx.PamMoveTrackerComponentData Data => data as FrostySdk.Ebx.PamMoveTrackerComponentData;
		public override string DisplayName => "PamMoveTrackerComponent";

		public PamMoveTrackerComponent(FrostySdk.Ebx.PamMoveTrackerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

