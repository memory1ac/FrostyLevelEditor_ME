using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomSpringboardEntityData))]
	public class PamCustomSpringboardEntity : PamFindableMovementVolumeEntity, IEntityData<FrostySdk.Ebx.PamCustomSpringboardEntityData>
	{
		public new FrostySdk.Ebx.PamCustomSpringboardEntityData Data => data as FrostySdk.Ebx.PamCustomSpringboardEntityData;

		public PamCustomSpringboardEntity(FrostySdk.Ebx.PamCustomSpringboardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

