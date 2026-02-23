using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIInputControlEntityData))]
	public class PamUIInputControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIInputControlEntityData>
	{
		public new FrostySdk.Ebx.PamUIInputControlEntityData Data => data as FrostySdk.Ebx.PamUIInputControlEntityData;
		public override string DisplayName => "PamUIInputControl";

		public PamUIInputControlEntity(FrostySdk.Ebx.PamUIInputControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

