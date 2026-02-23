using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAreaTriggerData))]
	public class PamAreaTrigger : TriggerEntity, IEntityData<FrostySdk.Ebx.PamAreaTriggerData>
	{
		public new FrostySdk.Ebx.PamAreaTriggerData Data => data as FrostySdk.Ebx.PamAreaTriggerData;

		public PamAreaTrigger(FrostySdk.Ebx.PamAreaTriggerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

