using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayQueryEntityData))]
	public class TimeOfDayQueryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayQueryEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDayQueryEntityData Data => data as FrostySdk.Ebx.TimeOfDayQueryEntityData;
		public override string DisplayName => "TimeOfDayQuery";

		public TimeOfDayQueryEntity(FrostySdk.Ebx.TimeOfDayQueryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

