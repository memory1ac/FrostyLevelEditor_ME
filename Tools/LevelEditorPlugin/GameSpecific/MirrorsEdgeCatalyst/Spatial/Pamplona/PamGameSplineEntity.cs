using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGameSplineEntityData))]
	public class PamGameSplineEntity : GameSplineEntity, IEntityData<FrostySdk.Ebx.PamGameSplineEntityData>
	{
		public new FrostySdk.Ebx.PamGameSplineEntityData Data => data as FrostySdk.Ebx.PamGameSplineEntityData;

		public PamGameSplineEntity(FrostySdk.Ebx.PamGameSplineEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

