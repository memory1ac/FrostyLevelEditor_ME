using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomizeProjectionCharacterEntityData))]
	public class PamCustomizeProjectionCharacterEntity : CustomizeBaseEntity, IEntityData<FrostySdk.Ebx.PamCustomizeProjectionCharacterEntityData>
	{
		public new FrostySdk.Ebx.PamCustomizeProjectionCharacterEntityData Data => data as FrostySdk.Ebx.PamCustomizeProjectionCharacterEntityData;
		public override string DisplayName => "PamCustomizeProjectionCharacter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamCustomizeProjectionCharacterEntity(FrostySdk.Ebx.PamCustomizeProjectionCharacterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

