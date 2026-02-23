using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIPlayerSelectEntityData))]
	public class PamUIPlayerSelectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIPlayerSelectEntityData>
	{
		public new FrostySdk.Ebx.PamUIPlayerSelectEntityData Data => data as FrostySdk.Ebx.PamUIPlayerSelectEntityData;
		public override string DisplayName => "PamUIPlayerSelect";

		public PamUIPlayerSelectEntity(FrostySdk.Ebx.PamUIPlayerSelectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

