using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CheckLinkEntityData))]
	public class CheckLinkEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CheckLinkEntityData>
	{
		public new FrostySdk.Ebx.CheckLinkEntityData Data => data as FrostySdk.Ebx.CheckLinkEntityData;
		public override string DisplayName => "CheckLink";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CheckLinkEntity(FrostySdk.Ebx.CheckLinkEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

