using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamEntryInputTriggerEntityData))]
	public class PamEntryInputTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamEntryInputTriggerEntityData>
	{
		public new FrostySdk.Ebx.PamEntryInputTriggerEntityData Data => data as FrostySdk.Ebx.PamEntryInputTriggerEntityData;
		public override string DisplayName => "PamEntryInputTrigger";

		public PamEntryInputTriggerEntity(FrostySdk.Ebx.PamEntryInputTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

