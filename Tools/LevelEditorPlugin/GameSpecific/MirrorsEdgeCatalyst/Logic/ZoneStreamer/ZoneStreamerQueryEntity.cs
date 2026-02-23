using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ZoneStreamerQueryEntityData))]
	public class ZoneStreamerQueryEntity : ZoneStreamerLogicEntity, IEntityData<FrostySdk.Ebx.ZoneStreamerQueryEntityData>
	{
		public new FrostySdk.Ebx.ZoneStreamerQueryEntityData Data => data as FrostySdk.Ebx.ZoneStreamerQueryEntityData;
		public override string DisplayName => "ZoneStreamerQuery";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ZoneStreamerQueryEntity(FrostySdk.Ebx.ZoneStreamerQueryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

