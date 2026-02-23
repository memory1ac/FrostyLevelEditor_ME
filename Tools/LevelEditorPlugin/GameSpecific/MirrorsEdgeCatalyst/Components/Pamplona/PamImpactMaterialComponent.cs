
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamImpactMaterialComponentData))]
	public class PamImpactMaterialComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamImpactMaterialComponentData>
	{
		public new FrostySdk.Ebx.PamImpactMaterialComponentData Data => data as FrostySdk.Ebx.PamImpactMaterialComponentData;
		public override string DisplayName => "PamImpactMaterialComponent";

		public PamImpactMaterialComponent(FrostySdk.Ebx.PamImpactMaterialComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

