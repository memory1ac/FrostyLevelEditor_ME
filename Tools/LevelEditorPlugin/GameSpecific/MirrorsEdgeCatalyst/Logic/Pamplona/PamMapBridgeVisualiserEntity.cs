using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapBridgeVisualiserEntityData))]
	public class PamMapBridgeVisualiserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapBridgeVisualiserEntityData>
	{
		public new FrostySdk.Ebx.PamMapBridgeVisualiserEntityData Data => data as FrostySdk.Ebx.PamMapBridgeVisualiserEntityData;
		public override string DisplayName => "PamMapBridgeVisualiser";

		public PamMapBridgeVisualiserEntity(FrostySdk.Ebx.PamMapBridgeVisualiserEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

