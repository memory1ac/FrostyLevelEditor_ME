using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIDivisionShowcaseProviderEntityData))]
	public class PamUIDivisionShowcaseProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIDivisionShowcaseProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIDivisionShowcaseProviderEntityData Data => data as FrostySdk.Ebx.PamUIDivisionShowcaseProviderEntityData;
		public override string DisplayName => "PamUIDivisionShowcaseProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIDivisionShowcaseProviderEntity(FrostySdk.Ebx.PamUIDivisionShowcaseProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

