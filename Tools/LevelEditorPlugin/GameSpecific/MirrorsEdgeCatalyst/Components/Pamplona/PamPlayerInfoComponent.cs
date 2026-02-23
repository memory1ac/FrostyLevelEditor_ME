
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPlayerInfoComponentData))]
	public class PamPlayerInfoComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamPlayerInfoComponentData>
	{
		public new FrostySdk.Ebx.PamPlayerInfoComponentData Data => data as FrostySdk.Ebx.PamPlayerInfoComponentData;
		public override string DisplayName => "PamPlayerInfoComponent";

		public PamPlayerInfoComponent(FrostySdk.Ebx.PamPlayerInfoComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

