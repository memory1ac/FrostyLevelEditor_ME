using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateTurretDisruptorResponseData))]
	public class PamAIStateTurretDisruptorResponse : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateTurretDisruptorResponseData>
	{
		public new FrostySdk.Ebx.PamAIStateTurretDisruptorResponseData Data => data as FrostySdk.Ebx.PamAIStateTurretDisruptorResponseData;
		public override string DisplayName => "PamAIStateTurretDisruptorResponse";

		public PamAIStateTurretDisruptorResponse(FrostySdk.Ebx.PamAIStateTurretDisruptorResponseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

