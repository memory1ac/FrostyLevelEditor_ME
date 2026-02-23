using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAnimationManagerData))]
	public class PamAIAnimationManager : AIAnimationManager, IEntityData<FrostySdk.Ebx.PamAIAnimationManagerData>
	{
		public new FrostySdk.Ebx.PamAIAnimationManagerData Data => data as FrostySdk.Ebx.PamAIAnimationManagerData;
		public override string DisplayName => "PamAIAnimationManager";

		public PamAIAnimationManager(FrostySdk.Ebx.PamAIAnimationManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

