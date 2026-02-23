using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMovementImpactSoundEntityData))]
	public class PamMovementImpactSoundEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMovementImpactSoundEntityData>
	{
		public new FrostySdk.Ebx.PamMovementImpactSoundEntityData Data => data as FrostySdk.Ebx.PamMovementImpactSoundEntityData;
		public override string DisplayName => "PamMovementImpactSound";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMovementImpactSoundEntity(FrostySdk.Ebx.PamMovementImpactSoundEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

