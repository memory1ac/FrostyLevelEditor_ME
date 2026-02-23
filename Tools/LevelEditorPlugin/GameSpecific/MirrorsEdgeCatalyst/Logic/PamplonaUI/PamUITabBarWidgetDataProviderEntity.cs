using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUITabBarWidgetDataProviderEntityData))]
	public class PamUITabBarWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUITabBarWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUITabBarWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUITabBarWidgetDataProviderEntityData;
		public override string DisplayName => "PamUITabBarWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUITabBarWidgetDataProviderEntity(FrostySdk.Ebx.PamUITabBarWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

