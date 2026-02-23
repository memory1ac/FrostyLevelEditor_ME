using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamKillVolumeEntityData))]
	public class PamKillVolumeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamKillVolumeEntityData>
	{
		public new FrostySdk.Ebx.PamKillVolumeEntityData Data => data as FrostySdk.Ebx.PamKillVolumeEntityData;
		public override string DisplayName => "PamKillVolume";

		public PamKillVolumeEntity(FrostySdk.Ebx.PamKillVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

