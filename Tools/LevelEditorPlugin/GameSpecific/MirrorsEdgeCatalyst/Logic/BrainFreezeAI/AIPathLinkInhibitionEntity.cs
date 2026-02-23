using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIPathLinkInhibitionEntityData))]
	public class AIPathLinkInhibitionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AIPathLinkInhibitionEntityData>
	{
		public new FrostySdk.Ebx.AIPathLinkInhibitionEntityData Data => data as FrostySdk.Ebx.AIPathLinkInhibitionEntityData;
		public override string DisplayName => "AIPathLinkInhibition";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AIPathLinkInhibitionEntity(FrostySdk.Ebx.AIPathLinkInhibitionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

