using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPresenceInfoEntityData))]
	public class PamPresenceInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPresenceInfoEntityData>
	{
		public new FrostySdk.Ebx.PamPresenceInfoEntityData Data => data as FrostySdk.Ebx.PamPresenceInfoEntityData;
		public override string DisplayName => "PamPresenceInfo";

		public PamPresenceInfoEntity(FrostySdk.Ebx.PamPresenceInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

