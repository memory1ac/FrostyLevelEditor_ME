using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIFireManagerBaseData))]
	public class PamAIFireManagerBase : AIFireManager, IEntityData<FrostySdk.Ebx.PamAIFireManagerBaseData>
	{
		public new FrostySdk.Ebx.PamAIFireManagerBaseData Data => data as FrostySdk.Ebx.PamAIFireManagerBaseData;
		public override string DisplayName => "PamAIFireManagerBase";

		public PamAIFireManagerBase(FrostySdk.Ebx.PamAIFireManagerBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

