using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AnimationBoneOffsetEntityData))]
	public class AnimationBoneOffsetEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AnimationBoneOffsetEntityData>
	{
		public new FrostySdk.Ebx.AnimationBoneOffsetEntityData Data => data as FrostySdk.Ebx.AnimationBoneOffsetEntityData;
		public override string DisplayName => "AnimationBoneOffset";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AnimationBoneOffsetEntity(FrostySdk.Ebx.AnimationBoneOffsetEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

