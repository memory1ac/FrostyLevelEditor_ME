using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAISensingManagerData))]
	public class PamAISensingManager : AISensingManager, IEntityData<FrostySdk.Ebx.PamAISensingManagerData>
	{
		public new FrostySdk.Ebx.PamAISensingManagerData Data => data as FrostySdk.Ebx.PamAISensingManagerData;
		public override string DisplayName => "PamAISensingManager";

		public PamAISensingManager(FrostySdk.Ebx.PamAISensingManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

