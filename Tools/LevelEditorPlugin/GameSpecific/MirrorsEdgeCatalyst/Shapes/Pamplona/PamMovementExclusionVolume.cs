using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMovementExclusionVolume))]
	public class PamMovementExclusionVolume : PamFindableMovementVolume, IEntityData<FrostySdk.Ebx.PamMovementExclusionVolume>
	{
		public new FrostySdk.Ebx.PamMovementExclusionVolume Data => data as FrostySdk.Ebx.PamMovementExclusionVolume;
		public override string DisplayName => "PamMovementExclusionVolume";

		public PamMovementExclusionVolume(FrostySdk.Ebx.PamMovementExclusionVolume inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

