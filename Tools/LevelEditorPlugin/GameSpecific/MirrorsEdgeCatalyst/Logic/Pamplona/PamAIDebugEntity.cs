using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIDebugEntityData))]
	public class PamAIDebugEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIDebugEntityData>
	{
		public new FrostySdk.Ebx.PamAIDebugEntityData Data => data as FrostySdk.Ebx.PamAIDebugEntityData;
		public override string DisplayName => "PamAIDebug";

		public PamAIDebugEntity(FrostySdk.Ebx.PamAIDebugEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

