using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSafeSpawnLockerEntityData))]
	public class PamSafeSpawnLockerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSafeSpawnLockerEntityData>
	{
		public new FrostySdk.Ebx.PamSafeSpawnLockerEntityData Data => data as FrostySdk.Ebx.PamSafeSpawnLockerEntityData;
		public override string DisplayName => "PamSafeSpawnLocker";

		public PamSafeSpawnLockerEntity(FrostySdk.Ebx.PamSafeSpawnLockerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

