using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIBookmarkWidgetDataProviderEntityData))]
	public class PamClientUIBookmarkWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUIBookmarkWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIBookmarkWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUIBookmarkWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUIBookmarkWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIBookmarkWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUIBookmarkWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

