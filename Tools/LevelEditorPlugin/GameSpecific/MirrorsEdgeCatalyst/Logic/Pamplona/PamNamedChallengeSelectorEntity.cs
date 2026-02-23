using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNamedChallengeSelectorEntityData))]
	public class PamNamedChallengeSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamNamedChallengeSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamNamedChallengeSelectorEntityData Data => data as FrostySdk.Ebx.PamNamedChallengeSelectorEntityData;
		public override string DisplayName => "PamNamedChallengeSelector";

		public PamNamedChallengeSelectorEntity(FrostySdk.Ebx.PamNamedChallengeSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

