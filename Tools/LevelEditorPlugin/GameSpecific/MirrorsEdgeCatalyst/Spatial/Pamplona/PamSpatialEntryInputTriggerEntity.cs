using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSpatialEntryInputTriggerEntityData))]
	public class PamSpatialEntryInputTriggerEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamSpatialEntryInputTriggerEntityData>
	{
		public new FrostySdk.Ebx.PamSpatialEntryInputTriggerEntityData Data => data as FrostySdk.Ebx.PamSpatialEntryInputTriggerEntityData;

		public PamSpatialEntryInputTriggerEntity(FrostySdk.Ebx.PamSpatialEntryInputTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

