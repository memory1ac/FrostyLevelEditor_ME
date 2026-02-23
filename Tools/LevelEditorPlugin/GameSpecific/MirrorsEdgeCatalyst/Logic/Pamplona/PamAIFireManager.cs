using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIFireManagerData))]
	public class PamAIFireManager : PamAIFireManagerBase, IEntityData<FrostySdk.Ebx.PamAIFireManagerData>
	{
		public new FrostySdk.Ebx.PamAIFireManagerData Data => data as FrostySdk.Ebx.PamAIFireManagerData;
		public override string DisplayName => "PamAIFireManager";

		public PamAIFireManager(FrostySdk.Ebx.PamAIFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

