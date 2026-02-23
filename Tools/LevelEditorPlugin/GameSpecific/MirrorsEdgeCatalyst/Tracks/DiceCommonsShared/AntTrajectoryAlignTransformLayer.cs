
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AntTrajectoryAlignTransformLayerData))]
	public class AntTrajectoryAlignTransformLayer : DiceTransformLayer, IEntityData<FrostySdk.Ebx.AntTrajectoryAlignTransformLayerData>
	{
		public new FrostySdk.Ebx.AntTrajectoryAlignTransformLayerData Data => data as FrostySdk.Ebx.AntTrajectoryAlignTransformLayerData;
		public override string DisplayName => "AntTrajectoryAlignTransformLayer";

		public AntTrajectoryAlignTransformLayer(FrostySdk.Ebx.AntTrajectoryAlignTransformLayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

