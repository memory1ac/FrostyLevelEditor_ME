using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomJumpOrFallData))]
	public class PamCustomJumpOrFall : PamFindableMovementVolume, IEntityData<FrostySdk.Ebx.PamCustomJumpOrFallData>
	{
		public new FrostySdk.Ebx.PamCustomJumpOrFallData Data => data as FrostySdk.Ebx.PamCustomJumpOrFallData;
		public override string DisplayName => "PamCustomJumpOrFall";

		public PamCustomJumpOrFall(FrostySdk.Ebx.PamCustomJumpOrFallData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

