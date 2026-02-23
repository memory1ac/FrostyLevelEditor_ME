using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamRunnerKitEntityData))]
	public class PamRunnerKitEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamRunnerKitEntityData>
	{
		public new FrostySdk.Ebx.PamRunnerKitEntityData Data => data as FrostySdk.Ebx.PamRunnerKitEntityData;
		public override string DisplayName => "PamRunnerKit";

		public PamRunnerKitEntity(FrostySdk.Ebx.PamRunnerKitEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

