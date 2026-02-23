using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAISniperFireManagerData))]
	public class PamAISniperFireManager : PamAIFireManagerBase, IEntityData<FrostySdk.Ebx.PamAISniperFireManagerData>
	{
		public new FrostySdk.Ebx.PamAISniperFireManagerData Data => data as FrostySdk.Ebx.PamAISniperFireManagerData;
		public override string DisplayName => "PamAISniperFireManager";

		public PamAISniperFireManager(FrostySdk.Ebx.PamAISniperFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

