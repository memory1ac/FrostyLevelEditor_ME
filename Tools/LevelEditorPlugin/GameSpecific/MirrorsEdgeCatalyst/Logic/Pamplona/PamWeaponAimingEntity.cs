using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamWeaponAimingEntityData))]
	public class PamWeaponAimingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamWeaponAimingEntityData>
	{
		public new FrostySdk.Ebx.PamWeaponAimingEntityData Data => data as FrostySdk.Ebx.PamWeaponAimingEntityData;
		public override string DisplayName => "PamWeaponAiming";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamWeaponAimingEntity(FrostySdk.Ebx.PamWeaponAimingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

