using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamOnlineStatusEntityData))]
	public class PamOnlineStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamOnlineStatusEntityData>
	{
		public new FrostySdk.Ebx.PamOnlineStatusEntityData Data => data as FrostySdk.Ebx.PamOnlineStatusEntityData;
		public override string DisplayName => "PamOnlineStatus";

		public PamOnlineStatusEntity(FrostySdk.Ebx.PamOnlineStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

