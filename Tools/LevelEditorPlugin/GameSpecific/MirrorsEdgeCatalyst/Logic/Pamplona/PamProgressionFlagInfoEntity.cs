using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionFlagInfoEntityData))]
	public class PamProgressionFlagInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionFlagInfoEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionFlagInfoEntityData Data => data as FrostySdk.Ebx.PamProgressionFlagInfoEntityData;
		public override string DisplayName => "PamProgressionFlagInfo";

		public PamProgressionFlagInfoEntity(FrostySdk.Ebx.PamProgressionFlagInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

