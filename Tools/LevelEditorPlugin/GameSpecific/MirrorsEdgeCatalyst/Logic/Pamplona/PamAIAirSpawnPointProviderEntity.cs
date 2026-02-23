using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAirSpawnPointProviderEntityData))]
	public class PamAIAirSpawnPointProviderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIAirSpawnPointProviderEntityData>
	{
		public new FrostySdk.Ebx.PamAIAirSpawnPointProviderEntityData Data => data as FrostySdk.Ebx.PamAIAirSpawnPointProviderEntityData;
		public override string DisplayName => "PamAIAirSpawnPointProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamAIAirSpawnPointProviderEntity(FrostySdk.Ebx.PamAIAirSpawnPointProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

