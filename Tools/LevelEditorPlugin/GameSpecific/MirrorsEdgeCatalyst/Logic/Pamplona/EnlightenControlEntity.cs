using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EnlightenControlEntityData))]
	public class EnlightenControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EnlightenControlEntityData>
	{
		public new FrostySdk.Ebx.EnlightenControlEntityData Data => data as FrostySdk.Ebx.EnlightenControlEntityData;
		public override string DisplayName => "EnlightenControl";

		public EnlightenControlEntity(FrostySdk.Ebx.EnlightenControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

