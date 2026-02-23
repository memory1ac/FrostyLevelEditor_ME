using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIDroneFireManagerData))]
	public class PamAIDroneFireManager : PamAIBurstFireManager, IEntityData<FrostySdk.Ebx.PamAIDroneFireManagerData>
	{
		public new FrostySdk.Ebx.PamAIDroneFireManagerData Data => data as FrostySdk.Ebx.PamAIDroneFireManagerData;
		public override string DisplayName => "PamAIDroneFireManager";

		public PamAIDroneFireManager(FrostySdk.Ebx.PamAIDroneFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

