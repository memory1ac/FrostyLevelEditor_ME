using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAssaultModeSpawnGroupData))]
	public class PamAIAssaultModeSpawnGroup : PamAIGroup, IEntityData<FrostySdk.Ebx.PamAIAssaultModeSpawnGroupData>
	{
		public new FrostySdk.Ebx.PamAIAssaultModeSpawnGroupData Data => data as FrostySdk.Ebx.PamAIAssaultModeSpawnGroupData;
		public override string DisplayName => "PamAIAssaultModeSpawnGroup";

		public PamAIAssaultModeSpawnGroup(FrostySdk.Ebx.PamAIAssaultModeSpawnGroupData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

