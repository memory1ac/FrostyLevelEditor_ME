using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BoidsProximityTrackerEntityData))]
	public class BoidsProximityTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BoidsProximityTrackerEntityData>
	{
		public new FrostySdk.Ebx.BoidsProximityTrackerEntityData Data => data as FrostySdk.Ebx.BoidsProximityTrackerEntityData;
		public override string DisplayName => "BoidsProximityTracker";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public BoidsProximityTrackerEntity(FrostySdk.Ebx.BoidsProximityTrackerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

