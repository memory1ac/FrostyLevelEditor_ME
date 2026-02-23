using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CreatureFollowWaypointsEntityData))]
	public class CreatureFollowWaypointsEntity : NavigationInterface, IEntityData<FrostySdk.Ebx.CreatureFollowWaypointsEntityData>
	{
		public new FrostySdk.Ebx.CreatureFollowWaypointsEntityData Data => data as FrostySdk.Ebx.CreatureFollowWaypointsEntityData;
		public override string DisplayName => "CreatureFollowWaypoints";

		public CreatureFollowWaypointsEntity(FrostySdk.Ebx.CreatureFollowWaypointsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

