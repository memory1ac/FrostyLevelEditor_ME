
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OverlayColorsComponentData))]
	public class OverlayColorsComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.OverlayColorsComponentData>
	{
		public new FrostySdk.Ebx.OverlayColorsComponentData Data => data as FrostySdk.Ebx.OverlayColorsComponentData;
		public override string DisplayName => "OverlayColorsComponent";

		public OverlayColorsComponent(FrostySdk.Ebx.OverlayColorsComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

