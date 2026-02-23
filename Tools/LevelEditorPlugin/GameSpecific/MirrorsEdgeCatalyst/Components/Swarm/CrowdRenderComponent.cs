
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdRenderComponentData))]
	public class CrowdRenderComponent : BaseSwarmComponent, IEntityData<FrostySdk.Ebx.CrowdRenderComponentData>
	{
		public new FrostySdk.Ebx.CrowdRenderComponentData Data => data as FrostySdk.Ebx.CrowdRenderComponentData;
		public override string DisplayName => "CrowdRenderComponent";

		public CrowdRenderComponent(FrostySdk.Ebx.CrowdRenderComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

