using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAINavigationManagerData))]
	public class PamAINavigationManager : AINavigationManager, IEntityData<FrostySdk.Ebx.PamAINavigationManagerData>
	{
		public new FrostySdk.Ebx.PamAINavigationManagerData Data => data as FrostySdk.Ebx.PamAINavigationManagerData;
		public override string DisplayName => "PamAINavigationManager";

		public PamAINavigationManager(FrostySdk.Ebx.PamAINavigationManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

