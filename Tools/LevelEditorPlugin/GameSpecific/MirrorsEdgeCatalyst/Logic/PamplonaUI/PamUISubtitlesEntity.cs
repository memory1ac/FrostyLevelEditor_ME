using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUISubtitlesEntityData))]
	public class PamUISubtitlesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUISubtitlesEntityData>
	{
		public new FrostySdk.Ebx.PamUISubtitlesEntityData Data => data as FrostySdk.Ebx.PamUISubtitlesEntityData;
		public override string DisplayName => "PamUISubtitles";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUISubtitlesEntity(FrostySdk.Ebx.PamUISubtitlesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

