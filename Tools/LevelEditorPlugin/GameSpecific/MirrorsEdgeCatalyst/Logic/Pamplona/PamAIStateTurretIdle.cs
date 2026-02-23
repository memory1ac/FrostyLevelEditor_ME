using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateTurretIdleData))]
	public class PamAIStateTurretIdle : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateTurretIdleData>
	{
		public new FrostySdk.Ebx.PamAIStateTurretIdleData Data => data as FrostySdk.Ebx.PamAIStateTurretIdleData;
		public override string DisplayName => "PamAIStateTurretIdle";

		public PamAIStateTurretIdle(FrostySdk.Ebx.PamAIStateTurretIdleData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

