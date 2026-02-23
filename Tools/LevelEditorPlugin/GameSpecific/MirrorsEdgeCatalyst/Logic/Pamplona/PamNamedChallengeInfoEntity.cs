using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNamedChallengeInfoEntityData))]
	public class PamNamedChallengeInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamNamedChallengeInfoEntityData>
	{
		public new FrostySdk.Ebx.PamNamedChallengeInfoEntityData Data => data as FrostySdk.Ebx.PamNamedChallengeInfoEntityData;
		public override string DisplayName => "PamNamedChallengeInfo";

		public PamNamedChallengeInfoEntity(FrostySdk.Ebx.PamNamedChallengeInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

