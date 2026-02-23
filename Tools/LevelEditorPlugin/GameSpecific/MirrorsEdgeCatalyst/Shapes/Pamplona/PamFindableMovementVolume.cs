using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFindableMovementVolumeData))]
	public class PamFindableMovementVolume : OBB, IEntityData<FrostySdk.Ebx.PamFindableMovementVolumeData>
	{
		public new FrostySdk.Ebx.PamFindableMovementVolumeData Data => data as FrostySdk.Ebx.PamFindableMovementVolumeData;
		public override string DisplayName => "PamFindableMovementVolume";

		public PamFindableMovementVolume(FrostySdk.Ebx.PamFindableMovementVolumeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

