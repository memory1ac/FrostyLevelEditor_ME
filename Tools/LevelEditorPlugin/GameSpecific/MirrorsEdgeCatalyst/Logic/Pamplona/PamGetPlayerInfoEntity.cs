using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGetPlayerInfoEntityData))]
	public class PamGetPlayerInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamGetPlayerInfoEntityData>
	{
		public new FrostySdk.Ebx.PamGetPlayerInfoEntityData Data => data as FrostySdk.Ebx.PamGetPlayerInfoEntityData;
		public override string DisplayName => "PamGetPlayerInfo";

		public PamGetPlayerInfoEntity(FrostySdk.Ebx.PamGetPlayerInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

