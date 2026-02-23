using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFirstPartyStoreInteractionEntityData))]
	public class PamFirstPartyStoreInteractionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamFirstPartyStoreInteractionEntityData>
	{
		public new FrostySdk.Ebx.PamFirstPartyStoreInteractionEntityData Data => data as FrostySdk.Ebx.PamFirstPartyStoreInteractionEntityData;
		public override string DisplayName => "PamFirstPartyStoreInteraction";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamFirstPartyStoreInteractionEntity(FrostySdk.Ebx.PamFirstPartyStoreInteractionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

