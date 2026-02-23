using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionInterfaceEntityData))]
	public class PamProgressionInterfaceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionInterfaceEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionInterfaceEntityData Data => data as FrostySdk.Ebx.PamProgressionInterfaceEntityData;
		public override string DisplayName => "PamProgressionInterface";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamProgressionInterfaceEntity(FrostySdk.Ebx.PamProgressionInterfaceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

