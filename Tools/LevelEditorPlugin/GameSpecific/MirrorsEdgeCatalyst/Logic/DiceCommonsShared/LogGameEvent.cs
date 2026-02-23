using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LogGameEventData))]
	public class LogGameEvent : LogicEntity, IEntityData<FrostySdk.Ebx.LogGameEventData>
	{
		public new FrostySdk.Ebx.LogGameEventData Data => data as FrostySdk.Ebx.LogGameEventData;
		public override string DisplayName => "LogGameEvent";

		public LogGameEvent(FrostySdk.Ebx.LogGameEventData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

