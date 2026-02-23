using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RoninLiveEntityData))]
	public class RoninLiveEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RoninLiveEntityData>
	{
		public new FrostySdk.Ebx.RoninLiveEntityData Data => data as FrostySdk.Ebx.RoninLiveEntityData;
		public override string DisplayName => "RoninLive";

		public RoninLiveEntity(FrostySdk.Ebx.RoninLiveEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

