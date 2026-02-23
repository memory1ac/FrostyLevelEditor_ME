using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIRunnerKitDataProviderEntityData))]
	public class PamUIRunnerKitDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIRunnerKitDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIRunnerKitDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIRunnerKitDataProviderEntityData;
		public override string DisplayName => "PamUIRunnerKitDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIRunnerKitDataProviderEntity(FrostySdk.Ebx.PamUIRunnerKitDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

