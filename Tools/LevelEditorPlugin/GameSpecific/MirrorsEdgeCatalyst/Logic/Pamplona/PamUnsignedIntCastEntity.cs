using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUnsignedIntCastEntityData))]
	public class PamUnsignedIntCastEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUnsignedIntCastEntityData>
	{
		public new FrostySdk.Ebx.PamUnsignedIntCastEntityData Data => data as FrostySdk.Ebx.PamUnsignedIntCastEntityData;
		public override string DisplayName => "PamUnsignedIntCast";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUnsignedIntCastEntity(FrostySdk.Ebx.PamUnsignedIntCastEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

