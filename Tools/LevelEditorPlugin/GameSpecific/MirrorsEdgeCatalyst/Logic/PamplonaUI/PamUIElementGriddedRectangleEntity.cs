using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementGriddedRectangleEntityData))]
	public class PamUIElementGriddedRectangleEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementGriddedRectangleEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementGriddedRectangleEntityData Data => data as FrostySdk.Ebx.PamUIElementGriddedRectangleEntityData;
		public override string DisplayName => "PamUIElementGriddedRectangle";

		public PamUIElementGriddedRectangleEntity(FrostySdk.Ebx.PamUIElementGriddedRectangleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

