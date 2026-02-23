using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementMouseInputListenerEntityData))]
	public class PamUIElementMouseInputListenerEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementMouseInputListenerEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementMouseInputListenerEntityData Data => data as FrostySdk.Ebx.PamUIElementMouseInputListenerEntityData;
		public override string DisplayName => "PamUIElementMouseInputListener";

		public PamUIElementMouseInputListenerEntity(FrostySdk.Ebx.PamUIElementMouseInputListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

