using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGameStateAreaTriggerEntityData))]
	public class PamGameStateAreaTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamGameStateAreaTriggerEntityData>
	{
		public new FrostySdk.Ebx.PamGameStateAreaTriggerEntityData Data => data as FrostySdk.Ebx.PamGameStateAreaTriggerEntityData;
		public override string DisplayName => "PamGameStateAreaTrigger";

		public PamGameStateAreaTriggerEntity(FrostySdk.Ebx.PamGameStateAreaTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

