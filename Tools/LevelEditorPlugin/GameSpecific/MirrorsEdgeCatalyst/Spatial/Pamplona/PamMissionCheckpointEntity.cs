using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionCheckpointEntityData))]
	public class PamMissionCheckpointEntity : PamSpawnLocationEntity, IEntityData<FrostySdk.Ebx.PamMissionCheckpointEntityData>
	{
		public new FrostySdk.Ebx.PamMissionCheckpointEntityData Data => data as FrostySdk.Ebx.PamMissionCheckpointEntityData;

		public PamMissionCheckpointEntity(FrostySdk.Ebx.PamMissionCheckpointEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

