using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIPathfindingTesterData))]
	public class PamAIPathfindingTester : LogicEntity, IEntityData<FrostySdk.Ebx.PamAIPathfindingTesterData>
	{
		public new FrostySdk.Ebx.PamAIPathfindingTesterData Data => data as FrostySdk.Ebx.PamAIPathfindingTesterData;
		public override string DisplayName => "PamAIPathfindingTester";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamAIPathfindingTester(FrostySdk.Ebx.PamAIPathfindingTesterData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

