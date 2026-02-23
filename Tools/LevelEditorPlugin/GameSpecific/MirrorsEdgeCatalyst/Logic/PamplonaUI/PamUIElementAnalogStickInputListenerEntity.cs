using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementAnalogStickInputListenerEntityData))]
	public class PamUIElementAnalogStickInputListenerEntity : DiceUIAnalogStickInputListenerElement, IEntityData<FrostySdk.Ebx.PamUIElementAnalogStickInputListenerEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementAnalogStickInputListenerEntityData Data => data as FrostySdk.Ebx.PamUIElementAnalogStickInputListenerEntityData;
		public override string DisplayName => "PamUIElementAnalogStickInputListener";

		public PamUIElementAnalogStickInputListenerEntity(FrostySdk.Ebx.PamUIElementAnalogStickInputListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

