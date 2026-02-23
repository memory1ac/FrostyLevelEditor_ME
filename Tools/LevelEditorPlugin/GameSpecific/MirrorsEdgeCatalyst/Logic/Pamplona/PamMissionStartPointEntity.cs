using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMissionStartPointEntityData))]
	public class PamMissionStartPointEntity : PamStartPointEntity, IEntityData<FrostySdk.Ebx.PamMissionStartPointEntityData>
	{
		public new FrostySdk.Ebx.PamMissionStartPointEntityData Data => data as FrostySdk.Ebx.PamMissionStartPointEntityData;
		public override string DisplayName => "PamMissionStartPoint";

		public PamMissionStartPointEntity(FrostySdk.Ebx.PamMissionStartPointEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

