using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionStatusEntityData))]
	public class PamMissionStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMissionStatusEntityData>
	{
		public new FrostySdk.Ebx.PamMissionStatusEntityData Data => data as FrostySdk.Ebx.PamMissionStatusEntityData;
		public override string DisplayName => "PamMissionStatus";

		public PamMissionStatusEntity(FrostySdk.Ebx.PamMissionStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

