using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateFollowWaypointsData))]
	public class AIStateFollowWaypoints : AIState, IEntityData<FrostySdk.Ebx.AIStateFollowWaypointsData>
	{
		public new FrostySdk.Ebx.AIStateFollowWaypointsData Data => data as FrostySdk.Ebx.AIStateFollowWaypointsData;
		public override string DisplayName => "AIStateFollowWaypoints";

		public AIStateFollowWaypoints(FrostySdk.Ebx.AIStateFollowWaypointsData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

