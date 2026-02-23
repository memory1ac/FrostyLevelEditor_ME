using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapMarkerBatchOperationEntityData))]
	public class PamMapMarkerBatchOperationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapMarkerBatchOperationEntityData>
	{
		public new FrostySdk.Ebx.PamMapMarkerBatchOperationEntityData Data => data as FrostySdk.Ebx.PamMapMarkerBatchOperationEntityData;
		public override string DisplayName => "PamMapMarkerBatchOperation";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMapMarkerBatchOperationEntity(FrostySdk.Ebx.PamMapMarkerBatchOperationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

