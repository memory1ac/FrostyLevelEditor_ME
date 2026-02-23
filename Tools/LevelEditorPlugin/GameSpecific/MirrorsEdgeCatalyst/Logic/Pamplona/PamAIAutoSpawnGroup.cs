using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIAutoSpawnGroupData))]
	public class PamAIAutoSpawnGroup : PamAIGroup, IEntityData<FrostySdk.Ebx.PamAIAutoSpawnGroupData>
	{
		public new FrostySdk.Ebx.PamAIAutoSpawnGroupData Data => data as FrostySdk.Ebx.PamAIAutoSpawnGroupData;
		public override string DisplayName => "PamAIAutoSpawnGroup";

		public PamAIAutoSpawnGroup(FrostySdk.Ebx.PamAIAutoSpawnGroupData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

