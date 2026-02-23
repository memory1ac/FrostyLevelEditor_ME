using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementRectangleEntityData))]
	public class PamUIElementRectangleEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementRectangleEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementRectangleEntityData Data => data as FrostySdk.Ebx.PamUIElementRectangleEntityData;
		public override string DisplayName => "PamUIElementRectangle";

		public PamUIElementRectangleEntity(FrostySdk.Ebx.PamUIElementRectangleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

