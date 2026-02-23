using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMissionInfoEntityData))]
	public class PamUIMissionInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIMissionInfoEntityData>
	{
		public new FrostySdk.Ebx.PamUIMissionInfoEntityData Data => data as FrostySdk.Ebx.PamUIMissionInfoEntityData;
		public override string DisplayName => "PamUIMissionInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIMissionInfoEntity(FrostySdk.Ebx.PamUIMissionInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

