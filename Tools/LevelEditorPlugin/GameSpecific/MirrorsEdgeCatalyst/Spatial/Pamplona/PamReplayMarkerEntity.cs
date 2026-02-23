using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReplayMarkerEntityData))]
	public class PamReplayMarkerEntity : PamSharedContentMarkerEntity, IEntityData<FrostySdk.Ebx.PamReplayMarkerEntityData>
	{
		public new FrostySdk.Ebx.PamReplayMarkerEntityData Data => data as FrostySdk.Ebx.PamReplayMarkerEntityData;

		public PamReplayMarkerEntity(FrostySdk.Ebx.PamReplayMarkerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

