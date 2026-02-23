using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMissionsWidgetDataProviderEntityData))]
	public class PamUIMissionsWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIMissionsWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIMissionsWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIMissionsWidgetDataProviderEntityData;
		public override string DisplayName => "PamUIMissionsWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIMissionsWidgetDataProviderEntity(FrostySdk.Ebx.PamUIMissionsWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

