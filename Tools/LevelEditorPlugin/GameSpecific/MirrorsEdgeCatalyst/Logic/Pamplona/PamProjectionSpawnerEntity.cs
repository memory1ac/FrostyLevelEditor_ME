using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProjectionSpawnerEntityData))]
	public class PamProjectionSpawnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProjectionSpawnerEntityData>
	{
		public new FrostySdk.Ebx.PamProjectionSpawnerEntityData Data => data as FrostySdk.Ebx.PamProjectionSpawnerEntityData;
		public override string DisplayName => "PamProjectionSpawner";

		public PamProjectionSpawnerEntity(FrostySdk.Ebx.PamProjectionSpawnerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

