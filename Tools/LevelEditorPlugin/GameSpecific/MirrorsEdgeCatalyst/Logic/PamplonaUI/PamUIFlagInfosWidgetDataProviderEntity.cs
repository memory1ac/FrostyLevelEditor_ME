using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIFlagInfosWidgetDataProviderEntityData))]
	public class PamUIFlagInfosWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIFlagInfosWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIFlagInfosWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIFlagInfosWidgetDataProviderEntityData;
		public override string DisplayName => "PamUIFlagInfosWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIFlagInfosWidgetDataProviderEntity(FrostySdk.Ebx.PamUIFlagInfosWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

