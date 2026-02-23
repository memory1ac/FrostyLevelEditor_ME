using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionDescriptionEntityData))]
	public class PamMissionDescriptionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMissionDescriptionEntityData>
	{
		public new FrostySdk.Ebx.PamMissionDescriptionEntityData Data => data as FrostySdk.Ebx.PamMissionDescriptionEntityData;
		public override string DisplayName => "PamMissionDescription";

		public PamMissionDescriptionEntity(FrostySdk.Ebx.PamMissionDescriptionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

