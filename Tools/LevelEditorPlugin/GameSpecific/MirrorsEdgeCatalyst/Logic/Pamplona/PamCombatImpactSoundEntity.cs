using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCombatImpactSoundEntityData))]
	public class PamCombatImpactSoundEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCombatImpactSoundEntityData>
	{
		public new FrostySdk.Ebx.PamCombatImpactSoundEntityData Data => data as FrostySdk.Ebx.PamCombatImpactSoundEntityData;
		public override string DisplayName => "PamCombatImpactSound";

		public PamCombatImpactSoundEntity(FrostySdk.Ebx.PamCombatImpactSoundEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

