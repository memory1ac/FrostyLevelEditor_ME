using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDaySwitchEntityData))]
	public class TimeOfDaySwitchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDaySwitchEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDaySwitchEntityData Data => data as FrostySdk.Ebx.TimeOfDaySwitchEntityData;
		public override string DisplayName => "TimeOfDaySwitch";

		public TimeOfDaySwitchEntity(FrostySdk.Ebx.TimeOfDaySwitchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

