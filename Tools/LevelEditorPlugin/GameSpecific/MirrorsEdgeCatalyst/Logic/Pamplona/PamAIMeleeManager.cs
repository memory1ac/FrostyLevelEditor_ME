using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIMeleeManagerData))]
	public class PamAIMeleeManager : AIManagerBase, IEntityData<FrostySdk.Ebx.PamAIMeleeManagerData>
	{
		public new FrostySdk.Ebx.PamAIMeleeManagerData Data => data as FrostySdk.Ebx.PamAIMeleeManagerData;
		public override string DisplayName => "PamAIMeleeManager";

		public PamAIMeleeManager(FrostySdk.Ebx.PamAIMeleeManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

