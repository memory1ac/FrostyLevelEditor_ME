using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUncontrollableSlideData))]
	public class PamUncontrollableSlide : PamFindableMovementVolume, IEntityData<FrostySdk.Ebx.PamUncontrollableSlideData>
	{
		public new FrostySdk.Ebx.PamUncontrollableSlideData Data => data as FrostySdk.Ebx.PamUncontrollableSlideData;
		public override string DisplayName => "PamUncontrollableSlide";

		public PamUncontrollableSlide(FrostySdk.Ebx.PamUncontrollableSlideData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

