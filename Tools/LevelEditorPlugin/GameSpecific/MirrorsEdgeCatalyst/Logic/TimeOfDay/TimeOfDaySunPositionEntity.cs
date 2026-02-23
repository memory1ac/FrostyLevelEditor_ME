using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDaySunPositionEntityData))]
	public class TimeOfDaySunPositionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDaySunPositionEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDaySunPositionEntityData Data => data as FrostySdk.Ebx.TimeOfDaySunPositionEntityData;
		public override string DisplayName => "TimeOfDaySunPosition";

		public TimeOfDaySunPositionEntity(FrostySdk.Ebx.TimeOfDaySunPositionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

