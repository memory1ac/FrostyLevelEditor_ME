using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIRepeatWidgetDataProviderEntityData))]
	public class PamUIRepeatWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIRepeatWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIRepeatWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIRepeatWidgetDataProviderEntityData;
		public override string DisplayName => "PamUIRepeatWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIRepeatWidgetDataProviderEntity(FrostySdk.Ebx.PamUIRepeatWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

