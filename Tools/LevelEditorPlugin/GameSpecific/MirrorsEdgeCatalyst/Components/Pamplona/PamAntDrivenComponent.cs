
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAntDrivenComponentData))]
	public class PamAntDrivenComponent : AntDrivenComponent, IEntityData<FrostySdk.Ebx.PamAntDrivenComponentData>
	{
		public new FrostySdk.Ebx.PamAntDrivenComponentData Data => data as FrostySdk.Ebx.PamAntDrivenComponentData;
		public override string DisplayName => "PamAntDrivenComponent";

		public PamAntDrivenComponent(FrostySdk.Ebx.PamAntDrivenComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

