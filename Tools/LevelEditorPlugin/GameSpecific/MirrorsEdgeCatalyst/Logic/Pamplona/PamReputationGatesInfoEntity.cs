using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReputationGatesInfoEntityData))]
	public class PamReputationGatesInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamReputationGatesInfoEntityData>
	{
		public new FrostySdk.Ebx.PamReputationGatesInfoEntityData Data => data as FrostySdk.Ebx.PamReputationGatesInfoEntityData;
		public override string DisplayName => "PamReputationGatesInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamReputationGatesInfoEntity(FrostySdk.Ebx.PamReputationGatesInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

