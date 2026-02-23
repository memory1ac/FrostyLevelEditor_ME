using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFollowWaypointsData))]
	public class PamAIStateFollowWaypoints : AIStateFollowWaypoints, IEntityData<FrostySdk.Ebx.PamAIStateFollowWaypointsData>
	{
		public new FrostySdk.Ebx.PamAIStateFollowWaypointsData Data => data as FrostySdk.Ebx.PamAIStateFollowWaypointsData;
		public override string DisplayName => "PamAIStateFollowWaypoints";

		public PamAIStateFollowWaypoints(FrostySdk.Ebx.PamAIStateFollowWaypointsData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

