using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamRunnerKitManagerEntityData))]
	public class PamRunnerKitManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamRunnerKitManagerEntityData>
	{
		public new FrostySdk.Ebx.PamRunnerKitManagerEntityData Data => data as FrostySdk.Ebx.PamRunnerKitManagerEntityData;
		public override string DisplayName => "PamRunnerKitManager";

		public PamRunnerKitManagerEntity(FrostySdk.Ebx.PamRunnerKitManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

