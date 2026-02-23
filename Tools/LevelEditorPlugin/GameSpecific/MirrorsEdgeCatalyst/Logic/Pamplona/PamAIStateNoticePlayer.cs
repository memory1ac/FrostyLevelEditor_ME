using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIStateNoticePlayerData))]
	public class PamAIStateNoticePlayer : PamAIStateBase, IEntityData<FrostySdk.Ebx.PamAIStateNoticePlayerData>
	{
		public new FrostySdk.Ebx.PamAIStateNoticePlayerData Data => data as FrostySdk.Ebx.PamAIStateNoticePlayerData;
		public override string DisplayName => "PamAIStateNoticePlayer";

		public PamAIStateNoticePlayer(FrostySdk.Ebx.PamAIStateNoticePlayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

