using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIInputUnicodeEntityData))]
	public class PamUIInputUnicodeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIInputUnicodeEntityData>
	{
		public new FrostySdk.Ebx.PamUIInputUnicodeEntityData Data => data as FrostySdk.Ebx.PamUIInputUnicodeEntityData;
		public override string DisplayName => "PamUIInputUnicode";

		public PamUIInputUnicodeEntity(FrostySdk.Ebx.PamUIInputUnicodeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

