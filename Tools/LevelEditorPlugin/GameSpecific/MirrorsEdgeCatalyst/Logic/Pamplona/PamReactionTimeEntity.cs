using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReactionTimeEntityData))]
	public class PamReactionTimeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamReactionTimeEntityData>
	{
		public new FrostySdk.Ebx.PamReactionTimeEntityData Data => data as FrostySdk.Ebx.PamReactionTimeEntityData;
		public override string DisplayName => "PamReactionTime";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamReactionTimeEntity(FrostySdk.Ebx.PamReactionTimeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

