using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUnlockRewardEntityData))]
	public class PamUnlockRewardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUnlockRewardEntityData>
	{
		public new FrostySdk.Ebx.PamUnlockRewardEntityData Data => data as FrostySdk.Ebx.PamUnlockRewardEntityData;
		public override string DisplayName => "PamUnlockReward";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUnlockRewardEntity(FrostySdk.Ebx.PamUnlockRewardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

