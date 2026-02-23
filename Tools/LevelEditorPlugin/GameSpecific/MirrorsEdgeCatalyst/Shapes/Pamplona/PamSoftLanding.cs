using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSoftLandingData))]
	public class PamSoftLanding : PamFindableMovementVolume, IEntityData<FrostySdk.Ebx.PamSoftLandingData>
	{
		public new FrostySdk.Ebx.PamSoftLandingData Data => data as FrostySdk.Ebx.PamSoftLandingData;
		public override string DisplayName => "PamSoftLanding";

		public PamSoftLanding(FrostySdk.Ebx.PamSoftLandingData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

