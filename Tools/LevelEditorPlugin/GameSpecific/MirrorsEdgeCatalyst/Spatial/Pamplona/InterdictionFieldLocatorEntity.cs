using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InterdictionFieldLocatorEntityData))]
	public class InterdictionFieldLocatorEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.InterdictionFieldLocatorEntityData>
	{
		public new FrostySdk.Ebx.InterdictionFieldLocatorEntityData Data => data as FrostySdk.Ebx.InterdictionFieldLocatorEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public InterdictionFieldLocatorEntity(FrostySdk.Ebx.InterdictionFieldLocatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

