using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionInteractValidateEntityData))]
	public class PamMissionInteractValidateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMissionInteractValidateEntityData>
	{
		public new FrostySdk.Ebx.PamMissionInteractValidateEntityData Data => data as FrostySdk.Ebx.PamMissionInteractValidateEntityData;
		public override string DisplayName => "PamMissionInteractValidate";

		public PamMissionInteractValidateEntity(FrostySdk.Ebx.PamMissionInteractValidateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

