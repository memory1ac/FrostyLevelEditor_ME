using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateChargeCripplerData))]
	public class PamAIStateChargeCrippler : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateChargeCripplerData>
	{
		public new FrostySdk.Ebx.PamAIStateChargeCripplerData Data => data as FrostySdk.Ebx.PamAIStateChargeCripplerData;
		public override string DisplayName => "PamAIStateChargeCrippler";

		public PamAIStateChargeCrippler(FrostySdk.Ebx.PamAIStateChargeCripplerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

