using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionEntityData))]
	public class PamMissionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMissionEntityData>
	{
		public new FrostySdk.Ebx.PamMissionEntityData Data => data as FrostySdk.Ebx.PamMissionEntityData;
		public override string DisplayName => "PamMission";

		public PamMissionEntity(FrostySdk.Ebx.PamMissionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

