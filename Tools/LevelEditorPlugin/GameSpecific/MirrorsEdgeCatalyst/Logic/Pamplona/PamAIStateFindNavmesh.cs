using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateFindNavmeshData))]
	public class PamAIStateFindNavmesh : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateFindNavmeshData>
	{
		public new FrostySdk.Ebx.PamAIStateFindNavmeshData Data => data as FrostySdk.Ebx.PamAIStateFindNavmeshData;
		public override string DisplayName => "PamAIStateFindNavmesh";

		public PamAIStateFindNavmesh(FrostySdk.Ebx.PamAIStateFindNavmeshData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

