
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdPlacementComponentData))]
	public class CrowdPlacementComponent : BaseSwarmComponent, IEntityData<FrostySdk.Ebx.CrowdPlacementComponentData>
	{
		public new FrostySdk.Ebx.CrowdPlacementComponentData Data => data as FrostySdk.Ebx.CrowdPlacementComponentData;
		public override string DisplayName => "CrowdPlacementComponent";

		public CrowdPlacementComponent(FrostySdk.Ebx.CrowdPlacementComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

