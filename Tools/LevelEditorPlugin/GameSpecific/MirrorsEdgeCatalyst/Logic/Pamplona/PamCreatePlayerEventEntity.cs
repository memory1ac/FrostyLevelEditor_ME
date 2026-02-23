using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCreatePlayerEventEntityData))]
	public class PamCreatePlayerEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCreatePlayerEventEntityData>
	{
		public new FrostySdk.Ebx.PamCreatePlayerEventEntityData Data => data as FrostySdk.Ebx.PamCreatePlayerEventEntityData;
		public override string DisplayName => "PamCreatePlayerEvent";

		public PamCreatePlayerEventEntity(FrostySdk.Ebx.PamCreatePlayerEventEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

