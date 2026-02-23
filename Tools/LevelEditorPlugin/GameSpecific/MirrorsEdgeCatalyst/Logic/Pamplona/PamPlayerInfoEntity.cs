using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerInfoEntityData))]
	public class PamPlayerInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPlayerInfoEntityData>
	{
		public new FrostySdk.Ebx.PamPlayerInfoEntityData Data => data as FrostySdk.Ebx.PamPlayerInfoEntityData;
		public override string DisplayName => "PamPlayerInfo";

		public PamPlayerInfoEntity(FrostySdk.Ebx.PamPlayerInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

