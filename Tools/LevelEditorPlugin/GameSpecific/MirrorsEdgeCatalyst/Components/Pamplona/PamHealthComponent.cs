
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamHealthComponentData))]
	public class PamHealthComponent : CharacterHealthComponent, IEntityData<FrostySdk.Ebx.PamHealthComponentData>
	{
		public new FrostySdk.Ebx.PamHealthComponentData Data => data as FrostySdk.Ebx.PamHealthComponentData;
		public override string DisplayName => "PamHealthComponent";

		public PamHealthComponent(FrostySdk.Ebx.PamHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

