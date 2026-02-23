using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementInputActionListenerEntityData))]
	public class PamUIElementInputActionListenerEntity : DiceUIInputActionListenerElement, IEntityData<FrostySdk.Ebx.PamUIElementInputActionListenerEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementInputActionListenerEntityData Data => data as FrostySdk.Ebx.PamUIElementInputActionListenerEntityData;
		public override string DisplayName => "PamUIElementInputActionListener";

		public PamUIElementInputActionListenerEntity(FrostySdk.Ebx.PamUIElementInputActionListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

