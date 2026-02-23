using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIPauseEntityData))]
	public class PamUIPauseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIPauseEntityData>
	{
		public new FrostySdk.Ebx.PamUIPauseEntityData Data => data as FrostySdk.Ebx.PamUIPauseEntityData;
		public override string DisplayName => "PamUIPause";

		public PamUIPauseEntity(FrostySdk.Ebx.PamUIPauseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

