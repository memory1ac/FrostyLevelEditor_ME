using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapDistrictTrackerEntityData))]
	public class PamMapDistrictTrackerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapDistrictTrackerEntityData>
	{
		public new FrostySdk.Ebx.PamMapDistrictTrackerEntityData Data => data as FrostySdk.Ebx.PamMapDistrictTrackerEntityData;
		public override string DisplayName => "PamMapDistrictTracker";

		public PamMapDistrictTrackerEntity(FrostySdk.Ebx.PamMapDistrictTrackerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

