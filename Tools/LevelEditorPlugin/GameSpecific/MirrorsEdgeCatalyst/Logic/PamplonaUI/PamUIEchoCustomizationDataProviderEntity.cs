using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIEchoCustomizationDataProviderEntityData))]
	public class PamUIEchoCustomizationDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIEchoCustomizationDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIEchoCustomizationDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIEchoCustomizationDataProviderEntityData;
		public override string DisplayName => "PamUIEchoCustomizationDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIEchoCustomizationDataProviderEntity(FrostySdk.Ebx.PamUIEchoCustomizationDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

