using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementAnalogPadInputListenerEntityData))]
	public class PamUIElementAnalogPadInputListenerEntity : DiceUIAnalogPadInputListenerElement, IEntityData<FrostySdk.Ebx.PamUIElementAnalogPadInputListenerEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementAnalogPadInputListenerEntityData Data => data as FrostySdk.Ebx.PamUIElementAnalogPadInputListenerEntityData;
		public override string DisplayName => "PamUIElementAnalogPadInputListener";

		public PamUIElementAnalogPadInputListenerEntity(FrostySdk.Ebx.PamUIElementAnalogPadInputListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

