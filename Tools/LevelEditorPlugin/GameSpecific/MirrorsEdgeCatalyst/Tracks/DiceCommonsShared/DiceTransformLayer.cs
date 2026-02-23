
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DiceTransformLayerData))]
	public class DiceTransformLayer : TransformLayer, IEntityData<FrostySdk.Ebx.DiceTransformLayerData>
	{
		public new FrostySdk.Ebx.DiceTransformLayerData Data => data as FrostySdk.Ebx.DiceTransformLayerData;
		public override string DisplayName => "DiceTransformLayer";

		public DiceTransformLayer(FrostySdk.Ebx.DiceTransformLayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

