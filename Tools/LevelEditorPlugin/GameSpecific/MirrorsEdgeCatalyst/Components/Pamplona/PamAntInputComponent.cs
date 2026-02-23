
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAntInputComponentData))]
	public class PamAntInputComponent : AntInputComponent, IEntityData<FrostySdk.Ebx.PamAntInputComponentData>
	{
		public new FrostySdk.Ebx.PamAntInputComponentData Data => data as FrostySdk.Ebx.PamAntInputComponentData;
		public override string DisplayName => "PamAntInputComponent";

		public PamAntInputComponent(FrostySdk.Ebx.PamAntInputComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

