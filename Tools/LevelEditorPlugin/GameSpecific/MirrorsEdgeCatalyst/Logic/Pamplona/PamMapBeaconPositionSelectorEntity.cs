using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapBeaconPositionSelectorEntityData))]
	public class PamMapBeaconPositionSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapBeaconPositionSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamMapBeaconPositionSelectorEntityData Data => data as FrostySdk.Ebx.PamMapBeaconPositionSelectorEntityData;
		public override string DisplayName => "PamMapBeaconPositionSelector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMapBeaconPositionSelectorEntity(FrostySdk.Ebx.PamMapBeaconPositionSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

