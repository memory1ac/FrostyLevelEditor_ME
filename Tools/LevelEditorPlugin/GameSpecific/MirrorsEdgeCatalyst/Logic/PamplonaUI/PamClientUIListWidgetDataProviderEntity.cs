using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIListWidgetDataProviderEntityData))]
	public class PamClientUIListWidgetDataProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamClientUIListWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIListWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUIListWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUIListWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIListWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUIListWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

