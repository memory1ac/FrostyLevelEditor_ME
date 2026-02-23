using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NPSEntityData))]
	public class NPSEntity : LogicEntity, IEntityData<FrostySdk.Ebx.NPSEntityData>
	{
		public new FrostySdk.Ebx.NPSEntityData Data => data as FrostySdk.Ebx.NPSEntityData;
		public override string DisplayName => "NPS";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public NPSEntity(FrostySdk.Ebx.NPSEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

