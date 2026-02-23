using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIAutoDespawnManagerData))]
	public class AIAutoDespawnManager : AIManagerBase, IEntityData<FrostySdk.Ebx.AIAutoDespawnManagerData>
	{
		public new FrostySdk.Ebx.AIAutoDespawnManagerData Data => data as FrostySdk.Ebx.AIAutoDespawnManagerData;
		public override string DisplayName => "AIAutoDespawnManager";

		public AIAutoDespawnManager(FrostySdk.Ebx.AIAutoDespawnManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

