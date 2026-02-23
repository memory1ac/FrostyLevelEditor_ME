using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamChallengeMarkerEntityData))]
	public class PamChallengeMarkerEntity : PamSharedContentMarkerEntity, IEntityData<FrostySdk.Ebx.PamChallengeMarkerEntityData>
	{
		public new FrostySdk.Ebx.PamChallengeMarkerEntityData Data => data as FrostySdk.Ebx.PamChallengeMarkerEntityData;

		public PamChallengeMarkerEntity(FrostySdk.Ebx.PamChallengeMarkerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

