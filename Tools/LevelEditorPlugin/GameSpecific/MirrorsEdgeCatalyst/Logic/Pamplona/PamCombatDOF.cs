using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCombatDOFData))]
	public class PamCombatDOF : LogicEntity, IEntityData<FrostySdk.Ebx.PamCombatDOFData>
	{
		public new FrostySdk.Ebx.PamCombatDOFData Data => data as FrostySdk.Ebx.PamCombatDOFData;
		public override string DisplayName => "PamCombatDOF";

		public PamCombatDOF(FrostySdk.Ebx.PamCombatDOFData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

