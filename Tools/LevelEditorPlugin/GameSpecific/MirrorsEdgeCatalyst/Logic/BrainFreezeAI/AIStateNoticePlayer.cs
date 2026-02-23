using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIStateNoticePlayerData))]
	public class AIStateNoticePlayer : AIState, IEntityData<FrostySdk.Ebx.AIStateNoticePlayerData>
	{
		public new FrostySdk.Ebx.AIStateNoticePlayerData Data => data as FrostySdk.Ebx.AIStateNoticePlayerData;
		public override string DisplayName => "AIStateNoticePlayer";

		public AIStateNoticePlayer(FrostySdk.Ebx.AIStateNoticePlayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

