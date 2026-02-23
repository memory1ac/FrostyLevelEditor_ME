using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIDebugStartPointCategoryDataProviderEntityData))]
	public class PamUIDebugStartPointCategoryDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIDebugStartPointCategoryDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIDebugStartPointCategoryDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIDebugStartPointCategoryDataProviderEntityData;
		public override string DisplayName => "PamUIDebugStartPointCategoryDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIDebugStartPointCategoryDataProviderEntity(FrostySdk.Ebx.PamUIDebugStartPointCategoryDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

