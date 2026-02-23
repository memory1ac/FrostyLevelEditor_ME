
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFinisherCameraOriginTransformLayerData))]
	public class PamFinisherCameraOriginTransformLayer : TransformLayer, IEntityData<FrostySdk.Ebx.PamFinisherCameraOriginTransformLayerData>
	{
		public new FrostySdk.Ebx.PamFinisherCameraOriginTransformLayerData Data => data as FrostySdk.Ebx.PamFinisherCameraOriginTransformLayerData;
		public override string DisplayName => "PamFinisherCameraOriginTransformLayer";

		public PamFinisherCameraOriginTransformLayer(FrostySdk.Ebx.PamFinisherCameraOriginTransformLayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

