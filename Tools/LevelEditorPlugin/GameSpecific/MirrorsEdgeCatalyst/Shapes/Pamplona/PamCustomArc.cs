using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomArcData))]
	public class PamCustomArc : PamFindableMovementVolume, IEntityData<FrostySdk.Ebx.PamCustomArcData>
	{
		public new FrostySdk.Ebx.PamCustomArcData Data => data as FrostySdk.Ebx.PamCustomArcData;
		public override string DisplayName => "PamCustomArc";

		public PamCustomArc(FrostySdk.Ebx.PamCustomArcData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

