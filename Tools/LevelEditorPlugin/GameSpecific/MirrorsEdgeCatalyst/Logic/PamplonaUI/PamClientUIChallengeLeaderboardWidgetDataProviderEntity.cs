using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIChallengeLeaderboardWidgetDataProviderEntityData))]
	public class PamClientUIChallengeLeaderboardWidgetDataProviderEntity : PamClientUILeaderboardWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUIChallengeLeaderboardWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIChallengeLeaderboardWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUIChallengeLeaderboardWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUIChallengeLeaderboardWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIChallengeLeaderboardWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUIChallengeLeaderboardWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

