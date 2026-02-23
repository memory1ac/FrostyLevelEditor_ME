using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMovementImpactEffectEntityData))]
	public class PamMovementImpactEffectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMovementImpactEffectEntityData>
	{
		public new FrostySdk.Ebx.PamMovementImpactEffectEntityData Data => data as FrostySdk.Ebx.PamMovementImpactEffectEntityData;
		public override string DisplayName => "PamMovementImpactEffect";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMovementImpactEffectEntity(FrostySdk.Ebx.PamMovementImpactEffectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

