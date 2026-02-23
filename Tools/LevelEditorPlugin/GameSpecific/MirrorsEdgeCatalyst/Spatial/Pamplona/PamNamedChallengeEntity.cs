using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNamedChallengeEntityData))]
	public class PamNamedChallengeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamNamedChallengeEntityData>
	{
		public new FrostySdk.Ebx.PamNamedChallengeEntityData Data => data as FrostySdk.Ebx.PamNamedChallengeEntityData;

		public PamNamedChallengeEntity(FrostySdk.Ebx.PamNamedChallengeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

