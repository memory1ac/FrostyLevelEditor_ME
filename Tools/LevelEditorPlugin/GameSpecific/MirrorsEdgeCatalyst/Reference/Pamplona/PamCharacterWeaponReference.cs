using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCharacterWeaponReferenceData))]
	public class PamCharacterWeaponReference : LogicReferenceObject, IEntityData<FrostySdk.Ebx.PamCharacterWeaponReferenceData>
	{
		public new FrostySdk.Ebx.PamCharacterWeaponReferenceData Data => data as FrostySdk.Ebx.PamCharacterWeaponReferenceData;

		public PamCharacterWeaponReference(FrostySdk.Ebx.PamCharacterWeaponReferenceData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

