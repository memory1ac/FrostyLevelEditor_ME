using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BoidsNetworkNodeEntityData))]
	public class BoidsNetworkNodeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BoidsNetworkNodeEntityData>
	{
		public new FrostySdk.Ebx.BoidsNetworkNodeEntityData Data => data as FrostySdk.Ebx.BoidsNetworkNodeEntityData;
		public override string DisplayName => "BoidsNetworkNode";

		public BoidsNetworkNodeEntity(FrostySdk.Ebx.BoidsNetworkNodeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

