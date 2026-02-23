using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFramerateLockData))]
	public class PamFramerateLock : LogicEntity, IEntityData<FrostySdk.Ebx.PamFramerateLockData>
	{
		public new FrostySdk.Ebx.PamFramerateLockData Data => data as FrostySdk.Ebx.PamFramerateLockData;
		public override string DisplayName => "PamFramerateLock";

		public PamFramerateLock(FrostySdk.Ebx.PamFramerateLockData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

