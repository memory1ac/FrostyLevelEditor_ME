using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamNewsFeedQueryEntityData))]
	public class PamNewsFeedQueryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamNewsFeedQueryEntityData>
	{
		public new FrostySdk.Ebx.PamNewsFeedQueryEntityData Data => data as FrostySdk.Ebx.PamNewsFeedQueryEntityData;
		public override string DisplayName => "PamNewsFeedQuery";

		public PamNewsFeedQueryEntity(FrostySdk.Ebx.PamNewsFeedQueryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

