
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAISimpleLocomotionData))]
	public class PamAISimpleLocomotion : LocoComponent, IEntityData<FrostySdk.Ebx.PamAISimpleLocomotionData>
	{
		public new FrostySdk.Ebx.PamAISimpleLocomotionData Data => data as FrostySdk.Ebx.PamAISimpleLocomotionData;
		public override string DisplayName => "PamAISimpleLocomotion";

		public PamAISimpleLocomotion(FrostySdk.Ebx.PamAISimpleLocomotionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

