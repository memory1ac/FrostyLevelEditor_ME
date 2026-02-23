
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerCameraTransformLayerData))]
	public class PamPlayerCameraTransformLayer : TransformLayer, IEntityData<FrostySdk.Ebx.PamPlayerCameraTransformLayerData>
	{
		public new FrostySdk.Ebx.PamPlayerCameraTransformLayerData Data => data as FrostySdk.Ebx.PamPlayerCameraTransformLayerData;
		public override string DisplayName => "PamPlayerCameraTransformLayer";

		public PamPlayerCameraTransformLayer(FrostySdk.Ebx.PamPlayerCameraTransformLayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

