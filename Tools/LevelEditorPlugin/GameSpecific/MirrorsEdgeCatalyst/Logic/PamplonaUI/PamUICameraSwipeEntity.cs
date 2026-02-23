using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUICameraSwipeEntityData))]
	public class PamUICameraSwipeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUICameraSwipeEntityData>
	{
		public new FrostySdk.Ebx.PamUICameraSwipeEntityData Data => data as FrostySdk.Ebx.PamUICameraSwipeEntityData;
		public override string DisplayName => "PamUICameraSwipe";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUICameraSwipeEntity(FrostySdk.Ebx.PamUICameraSwipeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

