using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIFollowedWidgetDataProviderEntityData))]
	public class PamClientUIFollowedWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUIFollowedWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIFollowedWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUIFollowedWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUIFollowedWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIFollowedWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUIFollowedWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

