
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamEntityInteractionComponentData))]
	public class PamEntityInteractionComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamEntityInteractionComponentData>
	{
		public new FrostySdk.Ebx.PamEntityInteractionComponentData Data => data as FrostySdk.Ebx.PamEntityInteractionComponentData;
		public override string DisplayName => "PamEntityInteractionComponent";

		public PamEntityInteractionComponent(FrostySdk.Ebx.PamEntityInteractionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

