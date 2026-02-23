using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMusicTriggerEntityData))]
	public class PamMusicTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMusicTriggerEntityData>
	{
		public new FrostySdk.Ebx.PamMusicTriggerEntityData Data => data as FrostySdk.Ebx.PamMusicTriggerEntityData;
		public override string DisplayName => "PamMusicTrigger";

		public PamMusicTriggerEntity(FrostySdk.Ebx.PamMusicTriggerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

