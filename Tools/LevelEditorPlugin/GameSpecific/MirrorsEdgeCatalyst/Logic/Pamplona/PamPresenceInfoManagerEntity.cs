using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPresenceInfoManagerEntityData))]
	public class PamPresenceInfoManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPresenceInfoManagerEntityData>
	{
		public new FrostySdk.Ebx.PamPresenceInfoManagerEntityData Data => data as FrostySdk.Ebx.PamPresenceInfoManagerEntityData;
		public override string DisplayName => "PamPresenceInfoManager";

		public PamPresenceInfoManagerEntity(FrostySdk.Ebx.PamPresenceInfoManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

