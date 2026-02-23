using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDynamicNamedChallengeSelectorEntityData))]
	public class PamDynamicNamedChallengeSelectorEntity : PamNamedChallengeSelectorEntity, IEntityData<FrostySdk.Ebx.PamDynamicNamedChallengeSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamDynamicNamedChallengeSelectorEntityData Data => data as FrostySdk.Ebx.PamDynamicNamedChallengeSelectorEntityData;
		public override string DisplayName => "PamDynamicNamedChallengeSelector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamDynamicNamedChallengeSelectorEntity(FrostySdk.Ebx.PamDynamicNamedChallengeSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

