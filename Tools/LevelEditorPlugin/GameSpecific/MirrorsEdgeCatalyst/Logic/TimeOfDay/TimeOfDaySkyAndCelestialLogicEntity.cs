using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TimeOfDaySkyAndCelestialLogicEntityData))]
	public class TimeOfDaySkyAndCelestialLogicEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TimeOfDaySkyAndCelestialLogicEntityData>
	{
		public new FrostySdk.Ebx.TimeOfDaySkyAndCelestialLogicEntityData Data => data as FrostySdk.Ebx.TimeOfDaySkyAndCelestialLogicEntityData;
		public override string DisplayName => "TimeOfDaySkyAndCelestialLogic";

		public TimeOfDaySkyAndCelestialLogicEntity(FrostySdk.Ebx.TimeOfDaySkyAndCelestialLogicEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

