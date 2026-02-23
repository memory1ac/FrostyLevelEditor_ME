using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGloveDisruptorReceiverEntityData))]
	public class PamGloveDisruptorReceiverEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamGloveDisruptorReceiverEntityData>
	{
		public new FrostySdk.Ebx.PamGloveDisruptorReceiverEntityData Data => data as FrostySdk.Ebx.PamGloveDisruptorReceiverEntityData;
		public override string DisplayName => "PamGloveDisruptorReceiver";

		public PamGloveDisruptorReceiverEntity(FrostySdk.Ebx.PamGloveDisruptorReceiverEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

