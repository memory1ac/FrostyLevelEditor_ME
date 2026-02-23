using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDayManagerEntityData))]
	public class TimeOfDayManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDayManagerEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDayManagerEntityData Data => data as FrostySdk.Ebx.TimeOfDayManagerEntityData;
		public override string DisplayName => "TimeOfDayManager";

		public TimeOfDayManagerEntity(FrostySdk.Ebx.TimeOfDayManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

