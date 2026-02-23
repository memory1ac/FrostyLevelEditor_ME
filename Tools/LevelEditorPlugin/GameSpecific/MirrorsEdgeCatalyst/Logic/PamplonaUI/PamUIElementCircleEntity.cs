using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementCircleEntityData))]
	public class PamUIElementCircleEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementCircleEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementCircleEntityData Data => data as FrostySdk.Ebx.PamUIElementCircleEntityData;
		public override string DisplayName => "PamUIElementCircle";

		public PamUIElementCircleEntity(FrostySdk.Ebx.PamUIElementCircleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

