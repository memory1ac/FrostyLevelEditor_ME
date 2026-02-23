using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamLookAtPlayerTransformEntityData))]
	public class PamLookAtPlayerTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamLookAtPlayerTransformEntityData>
	{
		public new FrostySdk.Ebx.PamLookAtPlayerTransformEntityData Data => data as FrostySdk.Ebx.PamLookAtPlayerTransformEntityData;
		public override string DisplayName => "PamLookAtPlayerTransform";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamLookAtPlayerTransformEntity(FrostySdk.Ebx.PamLookAtPlayerTransformEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

