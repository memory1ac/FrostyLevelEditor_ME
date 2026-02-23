using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCombatDropEvaluatorEntityData))]
	public class PamCombatDropEvaluatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamCombatDropEvaluatorEntityData>
	{
		public new FrostySdk.Ebx.PamCombatDropEvaluatorEntityData Data => data as FrostySdk.Ebx.PamCombatDropEvaluatorEntityData;
		public override string DisplayName => "PamCombatDropEvaluator";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamCombatDropEvaluatorEntity(FrostySdk.Ebx.PamCombatDropEvaluatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

