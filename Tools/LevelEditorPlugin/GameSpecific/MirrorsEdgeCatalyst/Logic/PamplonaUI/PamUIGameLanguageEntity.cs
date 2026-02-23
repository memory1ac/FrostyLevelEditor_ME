using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIGameLanguageEntityData))]
	public class PamUIGameLanguageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIGameLanguageEntityData>
	{
		public new FrostySdk.Ebx.PamUIGameLanguageEntityData Data => data as FrostySdk.Ebx.PamUIGameLanguageEntityData;
		public override string DisplayName => "PamUIGameLanguage";

		public PamUIGameLanguageEntity(FrostySdk.Ebx.PamUIGameLanguageEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

