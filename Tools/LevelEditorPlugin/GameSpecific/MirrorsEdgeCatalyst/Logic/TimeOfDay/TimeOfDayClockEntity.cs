using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayClockEntityData))]
	public class TimeOfDayClockEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayClockEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDayClockEntityData Data => data as FrostySdk.Ebx.TimeOfDayClockEntityData;
		public override string DisplayName => "TimeOfDayClock";

		public TimeOfDayClockEntity(FrostySdk.Ebx.TimeOfDayClockEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

