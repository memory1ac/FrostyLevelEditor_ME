using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIAnimationManagerData))]
	public class AIAnimationManager : AIManagerBase, IEntityData<FrostySdk.Ebx.AIAnimationManagerData>
	{
		public new FrostySdk.Ebx.AIAnimationManagerData Data => data as FrostySdk.Ebx.AIAnimationManagerData;
		public override string DisplayName => "AIAnimationManager";

		public AIAnimationManager(FrostySdk.Ebx.AIAnimationManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

