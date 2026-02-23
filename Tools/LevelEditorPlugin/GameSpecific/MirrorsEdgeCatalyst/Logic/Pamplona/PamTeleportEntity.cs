using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamTeleportEntityData))]
	public class PamTeleportEntity : TeleportEntity, IEntityData<FrostySdk.Ebx.PamTeleportEntityData>
	{
		public new FrostySdk.Ebx.PamTeleportEntityData Data => data as FrostySdk.Ebx.PamTeleportEntityData;
		public override string DisplayName => "PamTeleport";

		public PamTeleportEntity(FrostySdk.Ebx.PamTeleportEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

