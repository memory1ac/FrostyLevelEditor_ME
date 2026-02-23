using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIBurstFireManagerData))]
	public class PamAIBurstFireManager : PamAIFireManagerBase, IEntityData<FrostySdk.Ebx.PamAIBurstFireManagerData>
	{
		public new FrostySdk.Ebx.PamAIBurstFireManagerData Data => data as FrostySdk.Ebx.PamAIBurstFireManagerData;
		public override string DisplayName => "PamAIBurstFireManager";

		public PamAIBurstFireManager(FrostySdk.Ebx.PamAIBurstFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

