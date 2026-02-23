using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionDebugFlagEntityData))]
	public class PamProgressionDebugFlagEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionDebugFlagEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionDebugFlagEntityData Data => data as FrostySdk.Ebx.PamProgressionDebugFlagEntityData;
		public override string DisplayName => "PamProgressionDebugFlag";

		public PamProgressionDebugFlagEntity(FrostySdk.Ebx.PamProgressionDebugFlagEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

