using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIEngineSoundEntityData))]
	public class PamAIEngineSoundEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIEngineSoundEntityData>
	{
		public new FrostySdk.Ebx.PamAIEngineSoundEntityData Data => data as FrostySdk.Ebx.PamAIEngineSoundEntityData;
		public override string DisplayName => "PamAIEngineSound";

		public PamAIEngineSoundEntity(FrostySdk.Ebx.PamAIEngineSoundEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

