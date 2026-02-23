using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSocialActivityEntityData))]
	public class PamSocialActivityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSocialActivityEntityData>
	{
		public new FrostySdk.Ebx.PamSocialActivityEntityData Data => data as FrostySdk.Ebx.PamSocialActivityEntityData;
		public override string DisplayName => "PamSocialActivity";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamSocialActivityEntity(FrostySdk.Ebx.PamSocialActivityEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

