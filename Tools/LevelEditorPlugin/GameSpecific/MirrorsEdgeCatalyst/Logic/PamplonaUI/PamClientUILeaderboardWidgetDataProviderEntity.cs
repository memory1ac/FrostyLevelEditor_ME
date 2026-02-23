using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUILeaderboardWidgetDataProviderEntityData))]
	public class PamClientUILeaderboardWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUILeaderboardWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUILeaderboardWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUILeaderboardWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUILeaderboardWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUILeaderboardWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUILeaderboardWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

