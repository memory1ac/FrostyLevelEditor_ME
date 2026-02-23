using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSubLevelTriggerControlEntityData))]
	public class PamSubLevelTriggerControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSubLevelTriggerControlEntityData>
	{
		public new FrostySdk.Ebx.PamSubLevelTriggerControlEntityData Data => data as FrostySdk.Ebx.PamSubLevelTriggerControlEntityData;
		public override string DisplayName => "PamSubLevelTriggerControl";

		public PamSubLevelTriggerControlEntity(FrostySdk.Ebx.PamSubLevelTriggerControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

