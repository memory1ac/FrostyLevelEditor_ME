using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIDebugStartPointDataProviderEntityData))]
	public class PamUIDebugStartPointDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIDebugStartPointDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIDebugStartPointDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIDebugStartPointDataProviderEntityData;
		public override string DisplayName => "PamUIDebugStartPointDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIDebugStartPointDataProviderEntity(FrostySdk.Ebx.PamUIDebugStartPointDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

