
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIBrainComponentData))]
	public class PamAIBrainComponent : AIBrainComponent, IEntityData<FrostySdk.Ebx.PamAIBrainComponentData>
	{
		public new FrostySdk.Ebx.PamAIBrainComponentData Data => data as FrostySdk.Ebx.PamAIBrainComponentData;
		public override string DisplayName => "PamAIBrainComponent";

		public PamAIBrainComponent(FrostySdk.Ebx.PamAIBrainComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

