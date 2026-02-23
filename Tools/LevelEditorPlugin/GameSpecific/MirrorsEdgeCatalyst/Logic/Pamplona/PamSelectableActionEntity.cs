using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSelectableActionEntityData))]
	public class PamSelectableActionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSelectableActionEntityData>
	{
		public new FrostySdk.Ebx.PamSelectableActionEntityData Data => data as FrostySdk.Ebx.PamSelectableActionEntityData;
		public override string DisplayName => "PamSelectableAction";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamSelectableActionEntity(FrostySdk.Ebx.PamSelectableActionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

