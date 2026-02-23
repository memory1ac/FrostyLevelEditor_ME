using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNamedChallengeTypeCompareEntityData))]
	public class PamNamedChallengeTypeCompareEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamNamedChallengeTypeCompareEntityData>
	{
		public new FrostySdk.Ebx.PamNamedChallengeTypeCompareEntityData Data => data as FrostySdk.Ebx.PamNamedChallengeTypeCompareEntityData;
		public override string DisplayName => "PamNamedChallengeTypeCompare";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamNamedChallengeTypeCompareEntity(FrostySdk.Ebx.PamNamedChallengeTypeCompareEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

