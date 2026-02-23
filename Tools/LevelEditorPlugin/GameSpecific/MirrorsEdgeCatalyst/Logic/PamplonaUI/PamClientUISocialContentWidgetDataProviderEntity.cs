using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUISocialContentWidgetDataProviderEntityData))]
	public class PamClientUISocialContentWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUISocialContentWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUISocialContentWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUISocialContentWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUISocialContentWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUISocialContentWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUISocialContentWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

