using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamStartPointEntityData))]
	public class PamStartPointEntity : StartPointEntity, IEntityData<FrostySdk.Ebx.PamStartPointEntityData>
	{
		public new FrostySdk.Ebx.PamStartPointEntityData Data => data as FrostySdk.Ebx.PamStartPointEntityData;
		public override string DisplayName => "PamStartPoint";

		public PamStartPointEntity(FrostySdk.Ebx.PamStartPointEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

