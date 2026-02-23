using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIOptionWidgetDataProviderEntityData))]
	public class PamUIOptionWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIOptionWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIOptionWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIOptionWidgetDataProviderEntityData;
		public override string DisplayName => "PamUIOptionWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIOptionWidgetDataProviderEntity(FrostySdk.Ebx.PamUIOptionWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

