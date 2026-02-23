using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSurgeLogicData))]
	public class PamSurgeLogic : LogicEntity, IEntityData<FrostySdk.Ebx.PamSurgeLogicData>
	{
		public new FrostySdk.Ebx.PamSurgeLogicData Data => data as FrostySdk.Ebx.PamSurgeLogicData;
		public override string DisplayName => "PamSurgeLogic";

		public PamSurgeLogic(FrostySdk.Ebx.PamSurgeLogicData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

