using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionManagerEntityData))]
	public class PamMissionManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMissionManagerEntityData>
	{
		public new FrostySdk.Ebx.PamMissionManagerEntityData Data => data as FrostySdk.Ebx.PamMissionManagerEntityData;
		public override string DisplayName => "PamMissionManager";

		public PamMissionManagerEntity(FrostySdk.Ebx.PamMissionManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

