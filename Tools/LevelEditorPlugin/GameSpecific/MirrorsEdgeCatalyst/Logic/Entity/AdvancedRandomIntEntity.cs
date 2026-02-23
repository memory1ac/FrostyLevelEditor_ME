using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AdvancedRandomIntEntityData))]
	public class AdvancedRandomIntEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AdvancedRandomIntEntityData>
	{
		public new FrostySdk.Ebx.AdvancedRandomIntEntityData Data => data as FrostySdk.Ebx.AdvancedRandomIntEntityData;
		public override string DisplayName => "AdvancedRandomInt";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AdvancedRandomIntEntity(FrostySdk.Ebx.AdvancedRandomIntEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

