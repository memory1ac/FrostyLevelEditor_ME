using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMouseControlEntityData))]
	public class PamUIMouseControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIMouseControlEntityData>
	{
		public new FrostySdk.Ebx.PamUIMouseControlEntityData Data => data as FrostySdk.Ebx.PamUIMouseControlEntityData;
		public override string DisplayName => "PamUIMouseControl";

		public PamUIMouseControlEntity(FrostySdk.Ebx.PamUIMouseControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

