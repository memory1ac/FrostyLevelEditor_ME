using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSpotlightEntityData))]
	public class PamSpotlightEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSpotlightEntityData>
	{
		public new FrostySdk.Ebx.PamSpotlightEntityData Data => data as FrostySdk.Ebx.PamSpotlightEntityData;
		public override string DisplayName => "PamSpotlight";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamSpotlightEntity(FrostySdk.Ebx.PamSpotlightEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

