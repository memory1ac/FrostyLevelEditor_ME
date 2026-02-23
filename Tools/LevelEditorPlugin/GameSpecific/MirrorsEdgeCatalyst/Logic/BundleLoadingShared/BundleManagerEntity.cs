using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BundleManagerEntityData))]
	public class BundleManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BundleManagerEntityData>
	{
		public new FrostySdk.Ebx.BundleManagerEntityData Data => data as FrostySdk.Ebx.BundleManagerEntityData;
		public override string DisplayName => "BundleManager";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public BundleManagerEntity(FrostySdk.Ebx.BundleManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

