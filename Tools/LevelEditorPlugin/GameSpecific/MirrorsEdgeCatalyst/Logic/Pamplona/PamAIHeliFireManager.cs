using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIHeliFireManagerData))]
	public class PamAIHeliFireManager : PamAIBurstFireManager, IEntityData<FrostySdk.Ebx.PamAIHeliFireManagerData>
	{
		public new FrostySdk.Ebx.PamAIHeliFireManagerData Data => data as FrostySdk.Ebx.PamAIHeliFireManagerData;
		public override string DisplayName => "PamAIHeliFireManager";

		public PamAIHeliFireManager(FrostySdk.Ebx.PamAIHeliFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

