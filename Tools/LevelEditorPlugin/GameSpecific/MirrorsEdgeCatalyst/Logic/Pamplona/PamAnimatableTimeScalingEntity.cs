using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAnimatableTimeScalingEntityData))]
	public class PamAnimatableTimeScalingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamAnimatableTimeScalingEntityData>
	{
		public new FrostySdk.Ebx.PamAnimatableTimeScalingEntityData Data => data as FrostySdk.Ebx.PamAnimatableTimeScalingEntityData;
		public override string DisplayName => "PamAnimatableTimeScaling";

		public PamAnimatableTimeScalingEntity(FrostySdk.Ebx.PamAnimatableTimeScalingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

