using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionPurchaseEntityData))]
	public class PamProgressionPurchaseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionPurchaseEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionPurchaseEntityData Data => data as FrostySdk.Ebx.PamProgressionPurchaseEntityData;
		public override string DisplayName => "PamProgressionPurchase";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamProgressionPurchaseEntity(FrostySdk.Ebx.PamProgressionPurchaseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

