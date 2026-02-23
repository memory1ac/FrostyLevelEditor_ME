using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamStopWatchEntityData))]
	public class PamStopWatchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamStopWatchEntityData>
	{
		public new FrostySdk.Ebx.PamStopWatchEntityData Data => data as FrostySdk.Ebx.PamStopWatchEntityData;
		public override string DisplayName => "PamStopWatch";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamStopWatchEntity(FrostySdk.Ebx.PamStopWatchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

