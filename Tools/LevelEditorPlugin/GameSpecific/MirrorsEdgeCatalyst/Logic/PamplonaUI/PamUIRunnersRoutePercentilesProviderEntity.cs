using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIRunnersRoutePercentilesProviderEntityData))]
	public class PamUIRunnersRoutePercentilesProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIRunnersRoutePercentilesProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIRunnersRoutePercentilesProviderEntityData Data => data as FrostySdk.Ebx.PamUIRunnersRoutePercentilesProviderEntityData;
		public override string DisplayName => "PamUIRunnersRoutePercentilesProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIRunnersRoutePercentilesProviderEntity(FrostySdk.Ebx.PamUIRunnersRoutePercentilesProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

