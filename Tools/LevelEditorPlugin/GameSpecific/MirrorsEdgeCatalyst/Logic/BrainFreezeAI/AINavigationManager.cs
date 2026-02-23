using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AINavigationManagerData))]
	public class AINavigationManager : NavigationInterface, IEntityData<FrostySdk.Ebx.AINavigationManagerData>
	{
		public new FrostySdk.Ebx.AINavigationManagerData Data => data as FrostySdk.Ebx.AINavigationManagerData;
		public override string DisplayName => "AINavigationManager";

		public AINavigationManager(FrostySdk.Ebx.AINavigationManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

