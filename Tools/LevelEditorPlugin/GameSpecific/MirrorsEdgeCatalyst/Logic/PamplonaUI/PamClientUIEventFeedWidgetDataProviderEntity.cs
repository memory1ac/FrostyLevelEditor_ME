using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIEventFeedWidgetDataProviderEntityData))]
	public class PamClientUIEventFeedWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUIEventFeedWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIEventFeedWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUIEventFeedWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUIEventFeedWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIEventFeedWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUIEventFeedWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

