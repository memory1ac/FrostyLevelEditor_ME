using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCharacterWeaponEntityData))]
	public class PamCharacterWeaponEntity : ActorEntity, IEntityData<FrostySdk.Ebx.PamCharacterWeaponEntityData>
	{
		public new FrostySdk.Ebx.PamCharacterWeaponEntityData Data => data as FrostySdk.Ebx.PamCharacterWeaponEntityData;

		public PamCharacterWeaponEntity(FrostySdk.Ebx.PamCharacterWeaponEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

