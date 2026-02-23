using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIScreenResolutionWidgetDataProviderEntityData))]
	public class PamUIScreenResolutionWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIScreenResolutionWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIScreenResolutionWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIScreenResolutionWidgetDataProviderEntityData;
		public override string DisplayName => "PamUIScreenResolutionWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIScreenResolutionWidgetDataProviderEntity(FrostySdk.Ebx.PamUIScreenResolutionWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

