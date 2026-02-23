using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayBatchSwitchEntityData))]
	public class TimeOfDayBatchSwitchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayBatchSwitchEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDayBatchSwitchEntityData Data => data as FrostySdk.Ebx.TimeOfDayBatchSwitchEntityData;
		public override string DisplayName => "TimeOfDayBatchSwitch";

		public TimeOfDayBatchSwitchEntity(FrostySdk.Ebx.TimeOfDayBatchSwitchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

