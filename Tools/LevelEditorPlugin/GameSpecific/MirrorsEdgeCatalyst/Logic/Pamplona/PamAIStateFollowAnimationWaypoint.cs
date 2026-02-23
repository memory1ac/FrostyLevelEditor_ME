using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFollowAnimationWaypointData))]
	public class PamAIStateFollowAnimationWaypoint : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateFollowAnimationWaypointData>
	{
		public new FrostySdk.Ebx.PamAIStateFollowAnimationWaypointData Data => data as FrostySdk.Ebx.PamAIStateFollowAnimationWaypointData;
		public override string DisplayName => "PamAIStateFollowAnimationWaypoint";

		public PamAIStateFollowAnimationWaypoint(FrostySdk.Ebx.PamAIStateFollowAnimationWaypointData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

