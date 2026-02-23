using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSafeSpawnTrackerEntityData))]
	public class PamSafeSpawnTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSafeSpawnTrackerEntityData>
	{
		public new FrostySdk.Ebx.PamSafeSpawnTrackerEntityData Data => data as FrostySdk.Ebx.PamSafeSpawnTrackerEntityData;
		public override string DisplayName => "PamSafeSpawnTracker";

		public PamSafeSpawnTrackerEntity(FrostySdk.Ebx.PamSafeSpawnTrackerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

