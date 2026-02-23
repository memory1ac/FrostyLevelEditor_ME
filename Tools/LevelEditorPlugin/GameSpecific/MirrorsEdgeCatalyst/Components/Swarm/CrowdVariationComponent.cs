
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CrowdVariationComponentData))]
	public class CrowdVariationComponent : BaseSwarmComponent, IEntityData<FrostySdk.Ebx.CrowdVariationComponentData>
	{
		public new FrostySdk.Ebx.CrowdVariationComponentData Data => data as FrostySdk.Ebx.CrowdVariationComponentData;
		public override string DisplayName => "CrowdVariationComponent";

		public CrowdVariationComponent(FrostySdk.Ebx.CrowdVariationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

