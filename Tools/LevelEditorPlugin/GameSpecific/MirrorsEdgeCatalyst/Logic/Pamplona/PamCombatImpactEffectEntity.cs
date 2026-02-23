using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCombatImpactEffectEntityData))]
	public class PamCombatImpactEffectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCombatImpactEffectEntityData>
	{
		public new FrostySdk.Ebx.PamCombatImpactEffectEntityData Data => data as FrostySdk.Ebx.PamCombatImpactEffectEntityData;
		public override string DisplayName => "PamCombatImpactEffect";

		public PamCombatImpactEffectEntity(FrostySdk.Ebx.PamCombatImpactEffectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

