using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNewsFeedManagerEntityData))]
	public class PamNewsFeedManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamNewsFeedManagerEntityData>
	{
		public new FrostySdk.Ebx.PamNewsFeedManagerEntityData Data => data as FrostySdk.Ebx.PamNewsFeedManagerEntityData;
		public override string DisplayName => "PamNewsFeedManager";

		public PamNewsFeedManagerEntity(FrostySdk.Ebx.PamNewsFeedManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

