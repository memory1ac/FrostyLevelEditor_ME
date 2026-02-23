using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUISystemEntityData))]
	public class PamUISystemEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUISystemEntityData>
	{
		public new FrostySdk.Ebx.PamUISystemEntityData Data => data as FrostySdk.Ebx.PamUISystemEntityData;
		public override string DisplayName => "PamUISystem";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUISystemEntity(FrostySdk.Ebx.PamUISystemEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

