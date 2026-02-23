
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAIHealthComponentData))]
	public class PamAIHealthComponent : PamHealthComponent, IEntityData<FrostySdk.Ebx.PamAIHealthComponentData>
	{
		public new FrostySdk.Ebx.PamAIHealthComponentData Data => data as FrostySdk.Ebx.PamAIHealthComponentData;
		public override string DisplayName => "PamAIHealthComponent";

		public PamAIHealthComponent(FrostySdk.Ebx.PamAIHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

