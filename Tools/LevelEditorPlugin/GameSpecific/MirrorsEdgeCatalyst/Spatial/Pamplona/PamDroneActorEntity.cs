using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDroneActorEntityData))]
	public class PamDroneActorEntity : ActorEntity, IEntityData<FrostySdk.Ebx.PamDroneActorEntityData>
	{
		public new FrostySdk.Ebx.PamDroneActorEntityData Data => data as FrostySdk.Ebx.PamDroneActorEntityData;

		public PamDroneActorEntity(FrostySdk.Ebx.PamDroneActorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

