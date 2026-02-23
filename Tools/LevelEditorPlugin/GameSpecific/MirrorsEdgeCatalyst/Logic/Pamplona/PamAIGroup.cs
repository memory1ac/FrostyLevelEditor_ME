using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIGroupData))]
	public class PamAIGroup : AIGroup, IEntityData<FrostySdk.Ebx.PamAIGroupData>
	{
		public new FrostySdk.Ebx.PamAIGroupData Data => data as FrostySdk.Ebx.PamAIGroupData;
		public override string DisplayName => "PamAIGroup";

		public PamAIGroup(FrostySdk.Ebx.PamAIGroupData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

