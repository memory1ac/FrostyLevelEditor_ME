using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUILoadScreenControlEntityData))]
	public class PamUILoadScreenControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUILoadScreenControlEntityData>
	{
		public new FrostySdk.Ebx.PamUILoadScreenControlEntityData Data => data as FrostySdk.Ebx.PamUILoadScreenControlEntityData;
		public override string DisplayName => "PamUILoadScreenControl";

		public PamUILoadScreenControlEntity(FrostySdk.Ebx.PamUILoadScreenControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

