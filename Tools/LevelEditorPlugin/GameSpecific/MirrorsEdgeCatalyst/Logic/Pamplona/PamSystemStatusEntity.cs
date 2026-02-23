using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSystemStatusEntityData))]
	public class PamSystemStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSystemStatusEntityData>
	{
		public new FrostySdk.Ebx.PamSystemStatusEntityData Data => data as FrostySdk.Ebx.PamSystemStatusEntityData;
		public override string DisplayName => "PamSystemStatus";

		public PamSystemStatusEntity(FrostySdk.Ebx.PamSystemStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

