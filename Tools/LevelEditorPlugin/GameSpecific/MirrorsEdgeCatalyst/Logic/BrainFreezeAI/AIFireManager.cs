using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIFireManagerData))]
	public class AIFireManager : AIManagerBase, IEntityData<FrostySdk.Ebx.AIFireManagerData>
	{
		public new FrostySdk.Ebx.AIFireManagerData Data => data as FrostySdk.Ebx.AIFireManagerData;
		public override string DisplayName => "AIFireManager";

		public AIFireManager(FrostySdk.Ebx.AIFireManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

