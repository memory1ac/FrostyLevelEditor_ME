using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomArcEntityData))]
	public class PamCustomArcEntity : PamFindableMovementVolumeEntity, IEntityData<FrostySdk.Ebx.PamCustomArcEntityData>
	{
		public new FrostySdk.Ebx.PamCustomArcEntityData Data => data as FrostySdk.Ebx.PamCustomArcEntityData;

		public PamCustomArcEntity(FrostySdk.Ebx.PamCustomArcEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

