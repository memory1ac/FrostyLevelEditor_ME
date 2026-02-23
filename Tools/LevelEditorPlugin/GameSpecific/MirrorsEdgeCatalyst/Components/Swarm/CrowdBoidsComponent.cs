
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdBoidsComponentData))]
	public class CrowdBoidsComponent : BaseSwarmComponent, IEntityData<FrostySdk.Ebx.CrowdBoidsComponentData>
	{
		public new FrostySdk.Ebx.CrowdBoidsComponentData Data => data as FrostySdk.Ebx.CrowdBoidsComponentData;
		public override string DisplayName => "CrowdBoidsComponent";

		public CrowdBoidsComponent(FrostySdk.Ebx.CrowdBoidsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

