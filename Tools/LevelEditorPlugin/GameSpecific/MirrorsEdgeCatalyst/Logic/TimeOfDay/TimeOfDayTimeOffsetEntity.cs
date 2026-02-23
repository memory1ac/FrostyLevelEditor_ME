using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayTimeOffsetEntityData))]
	public class TimeOfDayTimeOffsetEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayTimeOffsetEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDayTimeOffsetEntityData Data => data as FrostySdk.Ebx.TimeOfDayTimeOffsetEntityData;
		public override string DisplayName => "TimeOfDayTimeOffset";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public TimeOfDayTimeOffsetEntity(FrostySdk.Ebx.TimeOfDayTimeOffsetEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

