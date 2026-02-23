using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGameSplineData))]
	public class PamGameSpline : GameSpline, IEntityData<FrostySdk.Ebx.PamGameSplineData>
	{
		public new FrostySdk.Ebx.PamGameSplineData Data => data as FrostySdk.Ebx.PamGameSplineData;
		public override string DisplayName => "PamGameSpline";

		public PamGameSpline(FrostySdk.Ebx.PamGameSplineData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

