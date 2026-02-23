using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProgressionFlagGroupMapMarkersEntityData))]
	public class PamProgressionFlagGroupMapMarkersEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProgressionFlagGroupMapMarkersEntityData>
	{
		public new FrostySdk.Ebx.PamProgressionFlagGroupMapMarkersEntityData Data => data as FrostySdk.Ebx.PamProgressionFlagGroupMapMarkersEntityData;
		public override string DisplayName => "PamProgressionFlagGroupMapMarkers";

		public PamProgressionFlagGroupMapMarkersEntity(FrostySdk.Ebx.PamProgressionFlagGroupMapMarkersEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

