using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIMissionSelectEntityData))]
	public class PamClientUIMissionSelectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamClientUIMissionSelectEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIMissionSelectEntityData Data => data as FrostySdk.Ebx.PamClientUIMissionSelectEntityData;
		public override string DisplayName => "PamClientUIMissionSelect";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIMissionSelectEntity(FrostySdk.Ebx.PamClientUIMissionSelectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

