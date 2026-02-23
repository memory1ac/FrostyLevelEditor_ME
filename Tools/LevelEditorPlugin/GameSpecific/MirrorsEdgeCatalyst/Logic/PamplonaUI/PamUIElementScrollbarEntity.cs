using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementScrollbarEntityData))]
	public class PamUIElementScrollbarEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementScrollbarEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementScrollbarEntityData Data => data as FrostySdk.Ebx.PamUIElementScrollbarEntityData;
		public override string DisplayName => "PamUIElementScrollbar";

		public PamUIElementScrollbarEntity(FrostySdk.Ebx.PamUIElementScrollbarEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

