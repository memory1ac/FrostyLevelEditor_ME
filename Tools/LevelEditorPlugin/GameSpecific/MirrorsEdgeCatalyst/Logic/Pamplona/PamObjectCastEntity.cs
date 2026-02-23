using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamObjectCastEntityData))]
	public class PamObjectCastEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamObjectCastEntityData>
	{
		public new FrostySdk.Ebx.PamObjectCastEntityData Data => data as FrostySdk.Ebx.PamObjectCastEntityData;
		public override string DisplayName => "PamObjectCast";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamObjectCastEntity(FrostySdk.Ebx.PamObjectCastEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

