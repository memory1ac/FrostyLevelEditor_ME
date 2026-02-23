using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomSpringboardData))]
	public class PamCustomSpringboard : PamFindableMovementVolume, IEntityData<FrostySdk.Ebx.PamCustomSpringboardData>
	{
		public new FrostySdk.Ebx.PamCustomSpringboardData Data => data as FrostySdk.Ebx.PamCustomSpringboardData;
		public override string DisplayName => "PamCustomSpringboard";

		public PamCustomSpringboard(FrostySdk.Ebx.PamCustomSpringboardData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

