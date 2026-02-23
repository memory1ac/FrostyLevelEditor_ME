using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUINamedChallengeLeaderboardWidgetDataProviderEntityData))]
	public class PamClientUINamedChallengeLeaderboardWidgetDataProviderEntity : PamClientUILeaderboardWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUINamedChallengeLeaderboardWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUINamedChallengeLeaderboardWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUINamedChallengeLeaderboardWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUINamedChallengeLeaderboardWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUINamedChallengeLeaderboardWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUINamedChallengeLeaderboardWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

