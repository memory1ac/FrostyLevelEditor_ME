
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerTagComponentData))]
	public class PamPlayerTagComponent : ShaderParameterComponent, IEntityData<FrostySdk.Ebx.PamPlayerTagComponentData>
	{
		public new FrostySdk.Ebx.PamPlayerTagComponentData Data => data as FrostySdk.Ebx.PamPlayerTagComponentData;
		public override string DisplayName => "PamPlayerTagComponent";

		public PamPlayerTagComponent(FrostySdk.Ebx.PamPlayerTagComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

