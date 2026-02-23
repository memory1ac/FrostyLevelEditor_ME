
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAntQueryComponentData))]
	public class PamAntQueryComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamAntQueryComponentData>
	{
		public new FrostySdk.Ebx.PamAntQueryComponentData Data => data as FrostySdk.Ebx.PamAntQueryComponentData;
		public override string DisplayName => "PamAntQueryComponent";

		public PamAntQueryComponent(FrostySdk.Ebx.PamAntQueryComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

