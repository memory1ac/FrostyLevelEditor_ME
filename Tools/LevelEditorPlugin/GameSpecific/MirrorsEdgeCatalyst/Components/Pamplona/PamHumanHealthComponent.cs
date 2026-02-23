
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamHumanHealthComponentData))]
	public class PamHumanHealthComponent : PamHealthComponent, IEntityData<FrostySdk.Ebx.PamHumanHealthComponentData>
	{
		public new FrostySdk.Ebx.PamHumanHealthComponentData Data => data as FrostySdk.Ebx.PamHumanHealthComponentData;
		public override string DisplayName => "PamHumanHealthComponent";

		public PamHumanHealthComponent(FrostySdk.Ebx.PamHumanHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

