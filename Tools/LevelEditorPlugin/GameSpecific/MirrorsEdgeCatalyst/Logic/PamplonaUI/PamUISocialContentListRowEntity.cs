using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUISocialContentListRowEntityData))]
	public class PamUISocialContentListRowEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUISocialContentListRowEntityData>
	{
		public new FrostySdk.Ebx.PamUISocialContentListRowEntityData Data => data as FrostySdk.Ebx.PamUISocialContentListRowEntityData;
		public override string DisplayName => "PamUISocialContentListRow";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUISocialContentListRowEntity(FrostySdk.Ebx.PamUISocialContentListRowEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

