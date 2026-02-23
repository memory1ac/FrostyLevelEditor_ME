using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCharacterEntityData))]
	public class PamCharacterEntity : CharacterEntity, IEntityData<FrostySdk.Ebx.PamCharacterEntityData>
	{
		public new FrostySdk.Ebx.PamCharacterEntityData Data => data as FrostySdk.Ebx.PamCharacterEntityData;

		public PamCharacterEntity(FrostySdk.Ebx.PamCharacterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

